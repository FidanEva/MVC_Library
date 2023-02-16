using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Library.Startup))]
namespace MVC_Library
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
