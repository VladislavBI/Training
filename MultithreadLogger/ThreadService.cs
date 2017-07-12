using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadLogger
{
    public static class ThreadService
    {
       public static void WaitForThreads()
        {
            int maxThreads = 0;
            int placeHolder = 0;
            int availThreads = 0;
            int timeOutSeconds = 5;

            //Now wait until all threads from the Threadpool have returned
            while (timeOutSeconds > 0)
            {
                //figure out what the max worker thread count it
                System.Threading.ThreadPool.GetMaxThreads(out
                                     maxThreads, out placeHolder);
                System.Threading.ThreadPool.GetAvailableThreads(out availThreads,
                                                               out placeHolder);

                if (availThreads == maxThreads) break;
                // Sleep
                System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(1000));
                --timeOutSeconds;
            }
            // You can add logic here to log timeouts
        }
    }
}
