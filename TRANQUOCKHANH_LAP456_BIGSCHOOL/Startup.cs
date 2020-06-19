using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TRANQUOCKHANH_LAP456_BIGSCHOOL.Startup))]
namespace TRANQUOCKHANH_LAP456_BIGSCHOOL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
