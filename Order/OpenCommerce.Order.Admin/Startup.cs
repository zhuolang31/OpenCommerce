using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenCommerce.Order.Admin.Startup))]
namespace OpenCommerce.Order.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
