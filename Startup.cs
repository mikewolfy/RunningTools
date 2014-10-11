using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RunningTools.Startup))]
namespace RunningTools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
