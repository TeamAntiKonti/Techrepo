using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Techrepo.Web.Startup))]
namespace Techrepo.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
