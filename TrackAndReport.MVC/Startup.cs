using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrackAndReport.MVC.Startup))]
namespace TrackAndReport.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
