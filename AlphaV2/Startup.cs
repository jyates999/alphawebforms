using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlphaV2.Startup))]
namespace AlphaV2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
