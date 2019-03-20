using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab4th.Startup))]
namespace lab4th
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
