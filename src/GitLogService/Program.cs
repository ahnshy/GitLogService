﻿using System.Configuration;
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

                service.SetServiceName("Git Log RESTful API Windows Service");
                service.SetDisplayName("Git Log RESTful API Windows Service");
                service.SetDescription("This Windows service program is RESTful Service that converts Git Log to JSON for statistics.");

                //service.SetServiceName(ConfigurationManager.AppSettings["ServiceName"].ToString());
                //service.SetDisplayName(ConfigurationManager.AppSettings["ServiceDisplayName"].ToString());
                //service.SetDescription(ConfigurationManager.AppSettings["ServiceDescription"].ToString());
            });
        }
    }
}
