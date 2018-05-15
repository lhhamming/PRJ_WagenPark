using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WagenPark.Startup))]
namespace WagenPark
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
