using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sltw.Titan.WebApp.Startup))]
namespace Sltw.Titan.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
