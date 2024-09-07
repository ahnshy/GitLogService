using Microsoft.Owin.Hosting;
using System;

namespace GitLogService
{
    public class RestService
    {
        private IDisposable _app;

        public void Start()
        {
            _app = WebApp.Start<Startup>("http://localhost:8081");
        }

        public void Stop()
        {
            if (_app != null)
                _app.Dispose();
        }
    }
}
