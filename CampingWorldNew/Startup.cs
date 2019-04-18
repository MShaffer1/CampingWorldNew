using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CampingWorldNew.Startup))]
namespace CampingWorldNew
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
