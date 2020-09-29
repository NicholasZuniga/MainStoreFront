using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSF.UI.MVC.Startup))]
namespace MSF.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
