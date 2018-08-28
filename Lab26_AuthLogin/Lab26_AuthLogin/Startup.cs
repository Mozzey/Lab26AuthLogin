using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab26_AuthLogin.Startup))]
namespace Lab26_AuthLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
