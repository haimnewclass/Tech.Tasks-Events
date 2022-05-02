using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Tasks_Events.Core
{
    public class Manager
    {

        public void Run()
        {

            httpJob.CreateHTTPTask();

            httpJob.HandlerNumberArrived += queueTask1.AddNewItem;
            httpJob.HandlerNumberArrived += queueTask2.AddNewItem;
            httpJob.HandlerNumberArrived += queueTask3.AddNewItem;
        }

        public HTTPJob httpJob = new HTTPJob();
        public QueueTask queueTask1 = new QueueTask();
        public QueueTask queueTask2 = new QueueTask() { Limit = 600 };    
        public QueueTask queueTask3 = new QueueTask() { Limit = 900 };



    }
}
