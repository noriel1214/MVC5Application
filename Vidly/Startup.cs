using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly.Startup))]
namespace Vidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

//git remote add origin https://github.com/noriel1214/Test1.git
//git branch -M main
//git push -u origin main
