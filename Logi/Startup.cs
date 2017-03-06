using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Logi.Startup))]
namespace Logi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
