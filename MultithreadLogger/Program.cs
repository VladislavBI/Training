using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadWorkerFactory factory = new ThreadWorkerFactory();
            for (int i = 0; i < 30; i++)
            {
                factory.CreateRandomWork();
            }
            ThreadService.WaitForThreads();
            //Console.ReadLine();
        }
        /// <summary>
        /// Blocks until all worker threads have returned to the thread pool.
        /// A good timeout value is 30 seconds.
        /// </summary>
      
    }
}
