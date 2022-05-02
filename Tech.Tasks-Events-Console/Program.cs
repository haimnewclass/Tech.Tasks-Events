using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Tasks_Events_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tech.Tasks_Events.Core.Manager manager = new Tech.Tasks_Events.Core.Manager();
            manager.Run();

            while (true)
            {
                Console.WriteLine($"{manager.queueTask1.q.Count} {manager.queueTask2.q.Count} {manager.queueTask3.q.Count} ");
                System.Threading.Thread.Sleep(2000);
            }

        }
    }
}
