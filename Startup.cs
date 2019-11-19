using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CONTACTS.Startup))]
namespace CONTACTS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
