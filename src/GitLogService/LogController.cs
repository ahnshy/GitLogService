using System.Web.Http;

namespace GitLogService
{
    public class LogController : ApiController
    {
        public string Get()
        {
            return "log sample";
        }
    }
}
