using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(SignalRMvc.Startup))]
namespace SignalRMvc
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}