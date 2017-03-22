using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVPGithubApp.Startup))]
namespace MVPGithubApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
