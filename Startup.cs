using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment3_N01392504.Startup))]
namespace Assignment3_N01392504
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
