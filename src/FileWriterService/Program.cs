using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FileWriterService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            var fileWriterService = new FileWriterService();

            if (Environment.UserInteractive)
            {
                fileWriterService.Debug(null);
            }
            else
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                    fileWriterService    
                };
                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}
