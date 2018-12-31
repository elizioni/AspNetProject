using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetProject.Startup))]
namespace AspNetProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
