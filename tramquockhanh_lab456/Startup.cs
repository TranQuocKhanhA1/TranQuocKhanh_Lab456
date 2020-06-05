using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tramquockhanh_lab456.Startup))]
namespace tramquockhanh_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
