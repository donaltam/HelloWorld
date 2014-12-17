using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloDatabase.Startup))]
namespace HelloDatabase
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
