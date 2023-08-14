using Highway__Console_.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highway__Console_.FactoryCar
{
    internal class EazyMode : ICarFactory
    {
        private const int CountCar = 30;
        private Random rand = new Random();

        public ICar Create()
        {
            int RandNum = rand.Next(0, 100);
            if (RandNum <= 50)
            {
                return new PassengerCar();
            }
            else if (RandNum <= 80)
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
