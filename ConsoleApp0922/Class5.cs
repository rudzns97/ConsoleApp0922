using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
    interface IRunnable2
    {
        void Run();
    }
    interface IFlyable2
    {
        void Fly();
    }
    abstract class Fly
    {
        public abstract void CFly();
    }
    class FlyingBike2 : Fly, IRunnable
    {
        public override void CFly()
        {
            Console.WriteLine("Bike Fly");
        }

        public void Run()
        {
            Console.WriteLine("Car Fly");
        }
    }
    class FlyingCar2 : Fly, IRunnable
    {
        public override void CFly()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine("Car Run");
        }
    }
    class Class5
    {
        static void Main()
        {
            FlyingCar2 car = new FlyingCar2();
            car.CFly();
            car.Run();
            Flying(car);

            FlyingBike2 bike = new FlyingBike2();
            bike.CFly();
            bike.Run();
            Flying(bike);

            Fly[] arr = new Fly[3];
            arr[0] = new FlyingCar2();
            arr[1] = new FlyingBike2();
            arr[2] = new FlyingBike2();

            foreach(Fly temp in arr)
            {
                temp.CFly();
            }
        }
        static void Flying(Fly flyer)
        {
            flyer.CFly();
        }
    }
}
