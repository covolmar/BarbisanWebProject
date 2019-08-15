using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BarbisanWebProject.Startup))]
namespace BarbisanWebProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
