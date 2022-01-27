using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeneralStore.MVC1.Startup))]
namespace GeneralStore.MVC1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
