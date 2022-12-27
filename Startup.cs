using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HAVE_IIdentity.Startup))]
namespace HAVE_IIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
