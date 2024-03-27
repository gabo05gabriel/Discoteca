using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pruebaaaaa.Startup))]
namespace pruebaaaaa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
