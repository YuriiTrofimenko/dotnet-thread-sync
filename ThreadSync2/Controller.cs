using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSync2
{
    class Controller
    {
        private Data data;
        private int id;

        public Controller(Data data, int id) {
            this.data = data;
            this.id = id;
        }

        public void DoWork() {

            /*lock (data) {
                if (data.GetState() == id)
                {
                    if (id == 1)
                    {
                        data.PrintTik();
                    }
                    else
                    {
                        data.PrintTac();
                    }
                    return true;
                }
                else {
                    return false;
                }
            }*/

            lock (data)
            {
                while (data.GetState() != id)
                {
                    Monitor.Wait(data);
                }

                if (id == 1)
                {
                    data.PrintTik();
                }
                else
                {
                    data.PrintTac();
                }

                Monitor.Pulse(data);
            }
        }
    }
}
