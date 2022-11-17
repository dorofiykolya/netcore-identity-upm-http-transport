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
                Namespace = "Game.Rpc",
                ClassName = "RpcBase"
            });
            File.WriteAllText(args[0], output);
        }
    }
}
