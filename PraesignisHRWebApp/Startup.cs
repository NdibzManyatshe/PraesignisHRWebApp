using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PraesignisHRWebApp.Startup))]
namespace PraesignisHRWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
