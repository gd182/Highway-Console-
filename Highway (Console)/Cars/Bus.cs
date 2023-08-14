using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highway__Console_.Cars
{
    class Bus : ICar
    {
        private int CountPas;

        public Bus () {
            Random rand = new Random();
            CountPas = rand.Next(5,50);
        }
        public int CountPassenger()
        {
            return CountPas;
        }
    }
}
