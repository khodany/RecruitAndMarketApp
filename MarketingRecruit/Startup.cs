using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarketingRecruit.Startup))]
namespace MarketingRecruit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
