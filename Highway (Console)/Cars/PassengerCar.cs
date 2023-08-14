using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highway__Console_.Cars
{
    class PassengerCar : ICar
    {
        private int CountPas;
        public PassengerCar()
        {
            Random rand = new Random();
            CountPas = rand.Next(1,4);
        }

        public int CountPassenger ()
        {
            return CountPas;
        }
    }
}
