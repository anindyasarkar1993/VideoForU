using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoForU.Startup))]
namespace VideoForU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
