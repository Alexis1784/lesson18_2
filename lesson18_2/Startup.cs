using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lesson18_2.Startup))]
namespace lesson18_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
