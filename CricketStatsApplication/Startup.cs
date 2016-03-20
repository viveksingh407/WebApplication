using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CricketStatsApplication.Startup))]
namespace CricketStatsApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
