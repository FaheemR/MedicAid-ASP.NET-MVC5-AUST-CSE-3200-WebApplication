using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedicAid.Startup))]
namespace MedicAid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
