using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSync
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            Controller c = new Controller(data);
            //c.Increase();
            //c.Increase();
            //Console.WriteLine(data.x);

            /*new Thread(c.Increase).Start();
            //new Thread(c.Increase).Start();
            new Thread(() => { c.Increase(); }).Start();
            //Thread.Sleep(1000);
            Console.WriteLine(data.x);*/

            new Thread(() => {
                for (int i = 0; i < 1000000; i++)
                {
                    c.Increase();
                }
                Console.WriteLine(data.x);
            }).Start();

            new Thread(() => {
                for (int i = 0; i < 1000000; i++)
                {
                    c.Increase();
                }
                Console.WriteLine(data.x);
            }).Start();

            //Thread.Sleep(3000);

            //Console.WriteLine(data.x);
        }
    }
}
