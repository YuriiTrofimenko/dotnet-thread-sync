using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSync2
{
    class Program
    {
        private static int loopCounter = 0;
        static void Main(string[] args)
        {

            /*Task
             * Добавить еще один метод распечатки в Data, а также - еще одно состояние
             */
            Data data = new Data();
            Controller c1 = new Controller(data, 1);
            Controller c2 = new Controller(data, 2);

            //new Thread(c1.doWork).Start();
            //new Thread(c2.doWork).Start();

            /*
             new Thread(() => {
                for (int i = 0; i < 10;)
                {
                    if (c1.DoWork())
                    {
                        i++;
                    }
                }
            }).Start();

            new Thread(() => {
                for (int i = 0; i < 10;)
                {
                    if (c2.DoWork())
                    {
                        i++;
                    }
                }
            }).Start();
             */

            /*new Thread(() => {
                for (int i = 0; i < 10;)
                {
                    if (c1.DoWork())
                    {
                        i++;
                    }
                    lock (data)
                    {
                        loopCounter++;
                    }
                }
                Console.WriteLine(loopCounter);
            }).Start();

            new Thread(() => {
                for (int i = 0; i < 10;)
                {
                    if (c2.DoWork())
                    {
                        i++;
                    }
                    lock (data)
                    {
                        loopCounter++;
                    }
                    
                }
                Console.WriteLine(loopCounter);
            }).Start();*/

            new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    c1.DoWork();
                    lock (data)
                    {
                        loopCounter++;
                    }
                }
                Console.WriteLine(loopCounter);
            }).Start();

            new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    c2.DoWork();
                    lock (data)
                    {
                        loopCounter++;
                    }

                }
                Console.WriteLine(loopCounter);
            }).Start();

            //Thread.Sleep(5000);
        }
    }
}
