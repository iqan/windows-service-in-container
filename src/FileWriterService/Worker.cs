using System;
using System.IO;
using System.Threading;

namespace FileWriterService
{
    internal class Worker
    {
        const string filePath = "C:\\Iqan\\FileWriterService\\";

        public void DoWork(string fileName)
        {
            AddToFile(fileName, $"{DateTime.Now} - Started Working...");
            Thread.Sleep(2000);
            AddToFile(fileName, $"{DateTime.Now} - Done Working.");
        }

        private void AddToFile(string fileName, string content)
        {
            File.AppendAllText($"{filePath}{fileName}", content);
        }
    }
}
