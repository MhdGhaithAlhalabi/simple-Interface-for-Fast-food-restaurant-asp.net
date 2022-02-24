using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fastfood2.Startup))]
namespace fastfood2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
