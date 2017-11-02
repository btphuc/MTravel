using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MTravel.Startup))]
namespace MTravel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
