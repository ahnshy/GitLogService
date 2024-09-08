using Microsoft.Owin.Hosting;
using System;
using System.Configuration;
using System.Linq;

namespace GitLogService
{
    public class RestService
    {
        private IDisposable _app;

        public void Start()
        {
            string protocol = "http";
            if (ConfigurationManager.AppSettings["UseHttps"].Contains(("true")) == true)
                protocol = "https";

            _app = WebApp.Start<Startup>(String.Format("{0}://{1}:{2}", protocol, ConfigurationManager.AppSettings["BaseAddress"], ConfigurationManager.AppSettings["Port"]));
        }

        public void Stop()
        {
            if (_app != null)
                _app.Dispose();
        }
    }
}
