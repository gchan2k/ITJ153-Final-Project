using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolAttendancePortal.Startup))]
namespace SchoolAttendancePortal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
