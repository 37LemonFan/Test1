using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> lis = new List<Task>();

           // List<TaskFactory> tasks = new List<TaskFactory>();

           TaskFactory taskFactory = new TaskFactory();

            lis.Add(taskFactory.StartNew(()=> { }));
            lis.Add(taskFactory.StartNew(() => { }));
            lis.Add(taskFactory.StartNew(() => { }));
            lis.Add(lis.ToArray(), t => { });

        }
    }
}
