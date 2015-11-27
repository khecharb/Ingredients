using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ingredients.Startup))]
namespace Ingredients
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
