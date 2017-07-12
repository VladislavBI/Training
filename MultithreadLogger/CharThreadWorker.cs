using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadLogger
{
    class CharThreadWorker : IThreadWorker
    {
        ThreadSaveLoggerService logger;
        public CharThreadWorker(ThreadSaveLoggerService loggerParam)
        {
            logger = loggerParam;
        }
        public void WorkProcess(object state)
        {
            Random r = new Random();
            char i = Convert.ToChar(r.Next(1, 100));
            ProcessResult(i);
        }

        private void ProcessResult(char i)
        {
            if (i >= 50)
            {
                try
                {
                    throw new ArgumentOutOfRangeException(i + " is not allowed");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    logger.LogException(ex);
                }
            }
            else
            {
                logger.LogInfoMessage("char worker result = " + i.ToString());
            }
        }
    }
}
