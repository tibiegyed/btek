using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(btek.Startup))]
namespace btek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
