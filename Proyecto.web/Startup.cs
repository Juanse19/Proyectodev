using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proyecto.web.Startup))]
namespace Proyecto.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
