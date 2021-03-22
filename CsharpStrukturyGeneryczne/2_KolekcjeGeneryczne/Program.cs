using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<Worker> queueOfWorkers = new Queue<Worker>();
            queueOfWorkers.Enqueue(new Worker { Name = "Bartek", LastName = "Koń" });
            queueOfWorkers.Enqueue(new Worker { Name = "Roman", LastName = "Zając" });

            queueOfWorkers.Enqueue(new Worker { Name = "Dominik", LastName = "Krem" });
            queueOfWorkers.Enqueue(new Worker { Name = "Armando", LastName = "Cukinia" });

            while (queueOfWorkers.Count > 0)
            {

                var worker = queueOfWorkers.Dequeue();
                Console.WriteLine(worker.Name + " " + worker.LastName);

            }

            Console.ReadKey();


        }
    }
}
