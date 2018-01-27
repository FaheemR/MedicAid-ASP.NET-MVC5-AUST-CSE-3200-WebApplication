using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedicAid_MVC.Startup))]
namespace MedicAid_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
