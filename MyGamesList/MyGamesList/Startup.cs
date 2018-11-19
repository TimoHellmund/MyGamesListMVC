using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyGamesList.Startup))]
namespace MyGamesList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
