using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Highway__Console_.Cars;

namespace Highway__Console_.FactoryCar
{
    internal class MiddleMode : ICarFactory
    {
        private const int CountCar = 60;
        private Random rand = new Random();

        public ICar Create()
        {
            int RandNum = rand.Next(0, 100);
            if (RandNum <= 30)
            {
                return new PassengerCar();
            }
            else if (RandNum <= 70)
            {
                return new Truck();
            }
            else
            {
                return new Bus();
            }
        }

        public int GetCountCar()
        {
            return CountCar;
        }
    }
}
