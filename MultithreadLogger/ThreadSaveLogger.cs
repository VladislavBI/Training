using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadLogger
{
    sealed class ThreadSaveLoggerService
    {
        static object locker = new object();

        const string filePath = @"D:\log.txt";

        private static readonly Lazy<ThreadSaveLoggerService> lazy =
            new Lazy<ThreadSaveLoggerService>(() => new ThreadSaveLoggerService());
        private ThreadSaveLoggerService() { }
        public static ThreadSaveLoggerService Instance { get { return lazy.Value; } }

        public void LogInfoMessage(string message)
        {
            lock (locker)
            {
                WriteInFile("Info: " + message);
            }
        }
        public void LogException(Exception ex)
        {
            lock (locker)
            {
                WriteInFile("Error: " +  ex.Message);
            }
        }

        private void WriteInFile(string message)
        {
            try
            {
                CreateFileIfNotExists();

                using (StreamWriter sw = new StreamWriter(filePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(message);
                }
            }
            catch (Exception ex)
            {

                var a = ex;
            }
        }

        private static void CreateFileIfNotExists()
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
        }
    }
}
