using System.Web.Http;

namespace GitLogService
{
    public class WelcomeController : ApiController
    {
        public string Get()
        {
            return "hi. ahnshy Welcome controller";
        }
    }
}
