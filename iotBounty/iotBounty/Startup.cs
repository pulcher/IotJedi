using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iotBounty.Startup))]
namespace iotBounty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
