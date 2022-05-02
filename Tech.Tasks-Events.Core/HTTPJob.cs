using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Tasks_Events.Core
{
    public class HTTPJob
    {
        public bool RunLoop = true;

        public delegate void delItem(QueueItem item);
        public event delItem HandlerNumberArrived;
        public Task CreateHTTPTask()
        {
            return Task.Factory.StartNew(async () => {
                while (RunLoop)
                {
                    HTTP http = new HTTP();
                    string str = await http.GetRandom();

                    str = str.Replace("[", "").Replace("]", "");
                    int num = Int32.Parse(str);

                    QueueItem queueItem = new QueueItem(num);
                    // queueTask.q.Enqueue(queueItem);
                    HandlerNumberArrived(queueItem);
                    // send event 
                    System.Threading.Thread.Sleep(5000);
                }

            });
        }
    }
}
