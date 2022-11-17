using System.Collections.Generic;
using Identity;

namespace Client.CodeGenerator
{
    public class RpcInspector
    {
        public static List<ControllerInspector.RouteInfo> Inspect()
        {
            return ControllerInspector.Inspect(typeof(ControllerInspector).Assembly);
        }
    }
}
