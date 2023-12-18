using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sales_website.Startup))]
namespace sales_website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
