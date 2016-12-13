using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(healthcare_timeline.Startup))]
namespace healthcare_timeline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
