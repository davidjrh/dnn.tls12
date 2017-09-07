using DotNetNuke.Web.Api;
using System.Net;

namespace DotNetNuke.Security.Tls12
{
    public class ServiceRouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {

            // Enable TLS 1.2
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; // .NET 4.5
        }
    }
}
