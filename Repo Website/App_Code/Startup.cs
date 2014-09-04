using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Repo_Website.Startup))]
namespace Repo_Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
