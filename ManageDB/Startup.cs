using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManageDB.Startup))]
namespace ManageDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
