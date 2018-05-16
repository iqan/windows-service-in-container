using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileWriterService
{
    public partial class FileWriterService : ServiceBase
    {
        private readonly Worker worker;
        private readonly string fileName;

        public FileWriterService()
        {
            InitializeComponent();

            worker = new Worker();
            fileName = "log.txt"; // TODO - read from config
        }

        internal void Debug(string[] args)
        {
            OnStart(args);
            OnStop();
        }

        protected override void OnStart(string[] args)
        {
            while (true)
            {
                worker.DoWork(fileName);
                Thread.Sleep(10000);
            }
        }

        protected override void OnStop()
        {
        }
    }
}
