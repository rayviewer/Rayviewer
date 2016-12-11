using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rayviewer.Startup))]
namespace Rayviewer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
