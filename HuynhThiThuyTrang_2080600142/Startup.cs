using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HuynhThiThuyTrang_2080600142.Startup))]
namespace HuynhThiThuyTrang_2080600142
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
