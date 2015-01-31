using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hanssens.Apps.Hourglass.Startup))]
namespace Hanssens.Apps.Hourglass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
