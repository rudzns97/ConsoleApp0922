using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
    interface IRunnable {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }
    class FlyingBike : IFlyable, IRunnable
    {
        public void Fly()
        {
            Console.WriteLine("Bike Fly");
        }

        public void Run()
        {
            Console.WriteLine("Bike Run");
        }
    }
    class FlyingCar : IFlyable, IRunnable
    {
        public void Fly()
        {
            Console.WriteLine("Car Fly");
        }

        public void Run()
        {
            Console.WriteLine("Car Run");
        }
    }
    class Class4
    {
        static void Main()
        {
            FlyingCar car = new FlyingCar();
            car.Fly();
            car.Run();
            Flying(car);

            FlyingBike bike = new FlyingBike();
            bike.Fly();
            bike.Run();
            Flying(bike);
        }

        static void Flying(IFlyable flyer) 
        {
            flyer.Fly();
        }
        static void Runnable(IRunnable flyer)
        {
            flyer.Run();
        }

        //static void Flying(FlyingBike car)
        //{
        //    car.Fly();
        //}

        //static void Flying(FlyingCar car)
        //{
        //    car.Fly();
        //}
    }
}
