using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlyingSchool.Startup))]
namespace FlyingSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
