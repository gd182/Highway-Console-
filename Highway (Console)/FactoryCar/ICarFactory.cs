using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Highway__Console_.Cars;

namespace Highway__Console_.FactoryCar
{
    interface ICarFactory
    {
        ICar Create();

        int GetCountCar();
    }
}
