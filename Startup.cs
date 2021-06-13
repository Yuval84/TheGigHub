using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheGigHub.Startup))]
namespace TheGigHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
