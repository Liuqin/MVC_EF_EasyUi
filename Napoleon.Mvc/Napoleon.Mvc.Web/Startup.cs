using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Napoleon.Mvc.Web.Startup))]
namespace Napoleon.Mvc.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
