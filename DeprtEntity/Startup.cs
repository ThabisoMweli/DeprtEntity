using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeprtEntity.Startup))]
namespace DeprtEntity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
