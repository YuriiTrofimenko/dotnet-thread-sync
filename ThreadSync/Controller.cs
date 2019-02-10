using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSync
{
    class Controller
    {
        private Data data;
        private object o = new object();
        public Controller (Data data){
            this.data = data;
        }
        public void Increase()
        {
            lock (data)
            {
                //Monitor.Enter(data);
                data.x++;
                //Monitor.Exit(data);
            }

        }
    }
}
