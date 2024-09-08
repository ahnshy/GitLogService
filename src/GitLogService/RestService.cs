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

            string address = String.Format("{0}://{1}:{2}", protocol, ConfigurationManager.AppSettings["BaseAddress"], ConfigurationManager.AppSettings["Port"]);
            Console.WriteLine(address);

            _app = WebApp.Start<Startup>(address);
        }

        public void Stop()
        {
            if (_app != null)
                _app.Dispose();
        }
    }
}
