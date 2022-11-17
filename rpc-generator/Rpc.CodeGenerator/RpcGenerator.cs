using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using HttpTransport.Rpc;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Client.CodeGenerator
{
    public class RpcGenerator
    {
        private static SyntaxList<UsingDirectiveSyntax> GetUsingList(List<string> usingList)
        {
            return List(usingList.Select(@using => UsingDirective(ParseName(@using))).ToArray());
        }

        public static string Generate(GeneratorConfiguration configuration)
        {
            var namespaceDeclaration = NamespaceDeclaration(ParseName(configuration.Namespace));

            var classDeclaration = ClassDeclaration(configuration.ClassName).AddModifiers(Token(SyntaxKind.PublicKeyword)).AddModifiers(Token(SyntaxKind.AbstractKeyword))
                            //variable
                            .AddMembers(FieldDeclaration(VariableDeclaration(IdentifierName(typeof(IRemoteRequest).GetFriendlyName()))
                                            .WithVariables(SingletonSeparatedList(VariableDeclarator(Identifier("_remoteRequest")))))
                                    .WithModifiers(TokenList(Token(SyntaxKind.PrivateKeyword))))
                            //constructor
                            .AddMembers(ConstructorDeclaration(Identifier(configuration.ClassName))
                                    .WithModifiers(TokenList(Token(SyntaxKind.ProtectedKeyword)))
                                    .WithParameterList(ParameterList(SingletonSeparatedList(Parameter(Identifier("request")).WithType(IdentifierName(typeof(IRemoteRequest).GetFriendlyName())))))
                                    .WithBody(Block(SingletonList<StatementSyntax>(ExpressionStatement(AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                                            IdentifierName("_remoteRequest"),
                                            IdentifierName("request")))))))
                    ;


            foreach (var rpcInfo in RpcInspector.Inspect())
            {
                classDeclaration = classDeclaration
                        .AddMembers(
                                //DECALARE METHOD
                                MethodDeclaration(
                                                returnType: GenericName(Identifier(typeof(IAsyncResponse).GetFriendlyName()))
                                                        .WithTypeArgumentList(TypeArgumentList(SingletonSeparatedList<TypeSyntax>(IdentifierName(rpcInfo.ResponseType.GetFriendlyName())))),
                                                identifier: Identifier("Request")
                                        )
                                        // METHOD MODIFICATIONS                
                                        // public
                                        .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                                        // parameter - request of RequestType 
                                        .WithParameterList(ParameterList(SingletonSeparatedList(Parameter(Identifier("request"))
                                                .WithType(IdentifierName(rpcInfo.RequestType.GetFriendlyName())))))
                                        // METHOD BODY
                                        .WithBody(Block(
                                                // var asyncRequest = new AsyncResponse();
                                                LocalDeclarationStatement(VariableDeclaration(IdentifierName("var"))
                                                        .WithVariables(SingletonSeparatedList(VariableDeclarator(Identifier("asyncRequest"))
                                                                .WithInitializer(EqualsValueClause(ObjectCreationExpression(GenericName(Identifier(typeof(AsyncResponse).GetFriendlyName()))
                                                                                .WithTypeArgumentList(
                                                                                        TypeArgumentList(
                                                                                                SingletonSeparatedList<TypeSyntax>(
                                                                                                        IdentifierName(rpcInfo.ResponseType.GetFriendlyName())))))
                                                                        .WithArgumentList(
                                                                                ArgumentList())))))),
                                                ExpressionStatement(
                                                        InvocationExpression(
                                                                        MemberAccessExpression(
                                                                                SyntaxKind.SimpleMemberAccessExpression,
                                                                                IdentifierName("_remoteRequest"),
                                                                                IdentifierName("Request")))
                                                                .WithArgumentList(
                                                                        ArgumentList(
                                                                                SeparatedList<ArgumentSyntax>(
                                                                                        new SyntaxNodeOrToken[]
                                                                                        {
                                                                                            Argument(
                                                                                                    IdentifierName("asyncRequest")),
                                                                                            Token(SyntaxKind.CommaToken),
                                                                                            Argument(
                                                                                                    TypeOfExpression(
                                                                                                            IdentifierName(rpcInfo.RequestType.GetFriendlyName()))),
                                                                                            Token(SyntaxKind.CommaToken),
                                                                                            Argument(
                                                                                                    IdentifierName("request")),
                                                                                            Token(SyntaxKind.CommaToken),
                                                                                            Argument(
                                                                                                    TypeOfExpression(
                                                                                                            IdentifierName(rpcInfo.ResponseType.GetFriendlyName()))),
                                                                                            Token(SyntaxKind.CommaToken),
                                                                                            Argument(
                                                                                                    IdentifierName(
                                                                                                            $"{typeof(HttpMethod).GetFriendlyName()}.{nameof(HttpMethod.Post)}"
                                                                                                    )),
                                                                                            Token(SyntaxKind.CommaToken),
                                                                                            Argument(LiteralExpression(
                                                                                                    SyntaxKind.StringLiteralExpression,
                                                                                                    Literal(rpcInfo.Path)))
                                                                                        })))),
                                                ReturnStatement(
                                                        IdentifierName("asyncRequest")))
                                        )
                        );
            }


            var compilationUnit = CompilationUnit()
                    .WithUsings(GetUsingList(configuration.Usings))
                    .AddMembers(namespaceDeclaration.AddMembers(classDeclaration));

            return compilationUnit.NormalizeWhitespace().ToString();
        }
    }
}
