using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Tasks_Events.Core
{
    public class QueueTask
    {
        public Queue<QueueItem> q = new Queue<QueueItem>();
        public int Limit = 300;
        public void AddNewItem(QueueItem item)
        {
            if(item.Num < Limit)
                q.Enqueue(item);
        }
    }
}
