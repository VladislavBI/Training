using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadLogger
{
    enum WorkType
    {
        intWork,
        charWork
    }
    class ThreadWorkerFactory
    {
        Dictionary<WorkType, IThreadWorker> workersDictionary = new Dictionary<WorkType, IThreadWorker>()
        {
            {WorkType.intWork, new IntThreadWorker(ThreadSaveLoggerService.Instance) },
            {WorkType.charWork, new CharThreadWorker(ThreadSaveLoggerService.Instance) }
        };

        public void CreateRandomWork()
        {
            Random r = new Random();
            WorkType WorkType = (WorkType)r.Next(0, 1);
            ThreadPool.QueueUserWorkItem(workersDictionary[WorkType].WorkProcess);
        }
    }
}
