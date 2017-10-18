using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCInClassDemo.Startup))]
namespace MVCInClassDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
