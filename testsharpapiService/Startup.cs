using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(testsharpapiService.Startup))]

namespace testsharpapiService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}