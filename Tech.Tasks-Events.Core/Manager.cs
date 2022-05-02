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

            CreateHTTPTask();
        }
        public bool RunLoop = true;

        public Queue<QueueItem> q = new Queue<QueueItem>();

        public Task CreateHTTPTask()
        {
            return Task.Factory.StartNew(async () => { 
                while(RunLoop)
                {
                    HTTP http = new HTTP();
                    string str = await http.GetRandom();

                    str = str.Replace("[", "").Replace("]", "");
                    int num = Int32.Parse(str);

                    QueueItem queueItem = new QueueItem(num);
                    q.Enqueue(queueItem);

                    System.Threading.Thread.Sleep(10000);
                }

            });
        }
    }
}
