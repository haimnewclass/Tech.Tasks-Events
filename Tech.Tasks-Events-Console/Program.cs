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
              
                System.Threading.Thread.Sleep(1000);
            }

        }
    }
}
