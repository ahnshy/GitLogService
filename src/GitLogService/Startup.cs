using Owin;
using System.Web.Http;

namespace GitLogService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = ConfigureApi();
            app.UseWebApi(config);
        }

        private HttpConfiguration ConfigureApi()
        {
            var config = new HttpConfiguration();
            return config;
        }
    }
}
