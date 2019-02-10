using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSync2
{
    class Data
    {
        //1 or 2
        private int state = 1;
        public void PrintTik() {
            Console.Write("Tik-");
            state = 2;
        }
        public void PrintTac()
        {
            Console.WriteLine("Tac");
            state = 1;
        }
        public int GetState() {
            return state;
        }
    }
}
