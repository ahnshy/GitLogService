using System.Configuration;
using Topshelf;

namespace GitLogService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HostFactory.Run(service =>
            {
                service.Service<RestService>(item =>
                {
                    item.ConstructUsing(() => new RestService());
                    item.WhenStarted(rest => rest.Start());
                    item.WhenStopped(rest => rest.Stop());
                    item.WhenShutdown(rest => rest.Stop());
                });
                service.RunAsLocalSystem();
                service.StartAutomatically();

                service.SetServiceName(ConfigurationManager.AppSettings["ServiceName"]);
                service.SetDisplayName(ConfigurationManager.AppSettings["ServiceDisplayName"]);
                service.SetDescription(ConfigurationManager.AppSettings["ServiceDescription"]);
            });
        }
    }
}
