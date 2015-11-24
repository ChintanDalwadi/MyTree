using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTreeApp.Startup))]
namespace MyTreeApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
