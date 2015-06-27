using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SavengerHunt.Startup))]
namespace SavengerHunt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
