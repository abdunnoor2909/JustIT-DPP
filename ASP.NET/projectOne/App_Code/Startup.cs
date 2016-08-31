using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projectOne.Startup))]
namespace projectOne
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
