using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VMTrail.Startup))]
namespace VMTrail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
