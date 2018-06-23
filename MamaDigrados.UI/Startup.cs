using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MamaDigrados.UI.Startup))]
namespace MamaDigrados.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
