using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blumind_Demo.Startup))]
namespace Blumind_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
