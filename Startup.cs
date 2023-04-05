using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(comfortWalk.Startup))]
namespace comfortWalk
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
