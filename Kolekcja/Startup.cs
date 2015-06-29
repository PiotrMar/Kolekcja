using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kolekcja.Startup))]
namespace Kolekcja
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
