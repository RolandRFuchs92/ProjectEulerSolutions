using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectEulerSolutions.Startup))]
namespace ProjectEulerSolutions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
