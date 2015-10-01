using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstGitDemo.Startup))]
namespace FirstGitDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
