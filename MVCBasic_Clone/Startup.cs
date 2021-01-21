using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBasic_Clone.Startup))]
namespace MVCBasic_Clone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
