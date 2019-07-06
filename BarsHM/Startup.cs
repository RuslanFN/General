using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BarsHM.Startup))]
namespace BarsHM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
