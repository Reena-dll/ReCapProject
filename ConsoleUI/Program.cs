using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine("Car ID: "+ car.CarId + " => BrandID: " + car.BrandId + " => ColorID: " + car.ColorId + " => Daily Price: " + car.DailyPrice + " => Description:  " + car.Description + " => Model Year: " + car.ModelYear);
            }

            Console.ReadLine();
        }
    }
}
