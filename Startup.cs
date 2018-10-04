using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JonoMot.Startup))]
namespace JonoMot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
