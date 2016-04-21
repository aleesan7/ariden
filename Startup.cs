using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ARIDEN.Startup))]
namespace ARIDEN
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
