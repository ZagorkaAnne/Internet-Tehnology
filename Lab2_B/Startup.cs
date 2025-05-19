using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab2_B.Startup))]
namespace Lab2_B
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
