using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameCriticApp.Startup))]
namespace GameCriticApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
