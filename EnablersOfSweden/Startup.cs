using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnablersOfSweden.Startup))]
namespace EnablersOfSweden
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
