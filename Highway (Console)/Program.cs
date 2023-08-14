using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Highway__Console_.FactoryCar;
using Highway__Console_.Cars;

namespace Highway__Console_
{
    internal class Program
    {
        static void WriteInf(ICar[] Car)
        {
            Console.WriteLine($"Количество машин: {Car.Length}");
            Console.WriteLine($"Из них:");
            Console.WriteLine($"Легковых: {Car.Where(item => item is PassengerCar).Count()} " +
                $"(пассажиров : {Car.Where(item => item is PassengerCar).Sum(item => item.CountPassenger())})");
            Console.WriteLine($"Фур: {Car.Where(item => item is Truck).Count()} " +
                $"(пассажиров : {Car.Where(item => item is Truck).Sum(item => item.CountPassenger())})");
            Console.WriteLine($"Автобусов: {Car.Where(item => item is Bus).Count()} " +
                $"(пассажиров : {Car.Where(item => item is Bus).Sum(item => item.CountPassenger())})");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете уровень сложности загруженности автострады");
            Console.WriteLine("1. Легкий\n2. Средний\n3. Сложный");
            int Num = int.Parse(Console.ReadLine());
            ICarFactory factory;
            switch (Num)
            {
                case 1:
                    {
                        factory = new EazyMode();
                        break;
                    }
                case 2:
                    {
                        factory = new MiddleMode();
                        break;
                    }
                case 3:
                    {
                        factory = new HardMode();
                        break;
                    }
                default: 
                    { 
                        return;
                    }
            }
            ICar[] Car = new ICar[factory.GetCountCar()];
            for (int i = 0; i< Car.Length; i++)
            {
                Car[i] = factory.Create();
            }
            WriteInf(Car);
            Console.ReadLine();
        }
    }
}
