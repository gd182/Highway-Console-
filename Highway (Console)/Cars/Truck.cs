using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Highway__Console_.Cars
{
    class Truck : ICar
    {
        private int CountPas;
        public Truck() 
        {
            Random rand = new Random();
            CountPas = rand.Next(1, 2);
        }
        public int CountPassenger()
        {
            return CountPas;
        }
    }
}
