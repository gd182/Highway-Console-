using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Highway__Console_.Cars;

namespace Highway__Console_.FactoryCar
{
    class HardMode : ICarFactory
    {
        private const int CountCar = 100;

        private Random rand = new Random();

        public ICar Create()
        {
            int RandNum = rand.Next(0,100);
            if (RandNum <= 20) 
            {
                return new PassengerCar();
            }
            else if (RandNum <=50)
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
