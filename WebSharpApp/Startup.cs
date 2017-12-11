using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebSharpApp.Startup))]

namespace WebSharpApp
{
  public partial class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      ConfigureMobileApp(app);
    }
  }
}