using System.Collections.Generic;

namespace Client.CodeGenerator
{
    public class GeneratorConfiguration
    {
        public List<string> Usings { get; set; } = new List<string>
                                                   {
                                                       "System",
                                                       "System.Collections.Generic"
                                                   };
        public string Namespace = "Rpcs";
        public string ClassName = "Rpc";
    }
}
