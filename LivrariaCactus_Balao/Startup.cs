using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LivrariaCactus_Balao.Startup))]
namespace LivrariaCactus_Balao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
