using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CohensCigars.Startup))]
namespace CohensCigars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
