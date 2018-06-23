using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MamaDigradosUI.Startup))]
namespace MamaDigradosUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
