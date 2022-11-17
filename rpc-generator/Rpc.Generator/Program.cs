using System.IO;
using Client.CodeGenerator;

namespace Client.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = RpcGenerator.Generate(new GeneratorConfiguration
            {
                Namespace = "HttpTransport.Identity",
                ClassName = "IdentityRpc"
            });
            File.WriteAllText(args[0], output);
        }
    }
}
