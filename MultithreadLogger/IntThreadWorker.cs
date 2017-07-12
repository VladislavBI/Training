using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadLogger
{
    class IntThreadWorker : IThreadWorker
    {
        ThreadSaveLoggerService logger;
        public IntThreadWorker(ThreadSaveLoggerService loggerParam)
        {
            logger = loggerParam;
        }
        public void WorkProcess(object state)
        {
            Random r = new Random();
            int i = r.Next(1, 100);
            ProcessResult(i);
        }
        private void ProcessResult(int i)
        {
            if (i >= 50)
            {
                try
                {
                    throw new ArgumentOutOfRangeException(i + " is out of range");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    logger.LogException(ex);
                }
            }
            else
            {
                logger.LogInfoMessage("int worker result = " + i.ToString());
            }
        }
    }


}
