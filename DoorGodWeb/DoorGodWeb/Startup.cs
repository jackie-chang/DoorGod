using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoorGodWeb.Startup))]
namespace DoorGodWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
