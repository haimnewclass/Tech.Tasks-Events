using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Tasks_Events.Core
{
    public class QueueItem
    {
        public QueueItem(int n)
        {
            Num = n;
            now = DateTime.Now; 
        }
        public int Num { get; set; }
        public DateTime now { get; set; }
    }
}
