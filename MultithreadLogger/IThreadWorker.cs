using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadLogger
{
    interface IThreadWorker
    {
        void WorkProcess(object state);
    }
}
