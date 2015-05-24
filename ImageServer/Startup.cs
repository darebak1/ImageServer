using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImageServer.Startup))]
namespace ImageServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
