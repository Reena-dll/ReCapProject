using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //Car car1 = new Car() { ColorId = 2, BrandId = 2, DailyPrice = 10, Description = "asdasdsa", ModelYear = "2000", Name = "a", };
            //carManager.Add(car1);

            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine("{0} => {1} => {2} => {3} => {4} => {5} => {6}"
                    ,car.CarId,car.Name,car.BrandId,car.ColorId,car.DailyPrice,car.Description,car.ModelYear);
            }

            Console.WriteLine("Marka ID'e Göre Getir****************");
            foreach (Car car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine("{0} => {1} => {2} => {3} => {4} => {5} => {6}"
                    ,car.CarId,car.Name,car.BrandId,car.ColorId,car.DailyPrice,car.Description,car.ModelYear);
            }

            Console.WriteLine("Rengine Göre Getir****************");
            foreach (Car car in carManager.GetCarsByColorId(2))
            {
               Console.WriteLine("{0} => {1} => {2} => {3} => {4} => {5} => {6}"
                    ,car.CarId,car.Name,car.BrandId,car.ColorId,car.DailyPrice,car.Description,car.ModelYear);
            }

            Console.WriteLine("Fiyat Aralığına Göre Getir****************");
            foreach (Car car in carManager.GetCarsByDailyPrice(200, 300))
            {
               Console.WriteLine("{0} => {1} => {2} => {3} => {4} => {5} => {6}"
                    ,car.CarId,car.Name,car.BrandId,car.ColorId,car.DailyPrice,car.Description,car.ModelYear);
            }
            


            //foreach (Car car in carManager.GetAll())
            //{
            //    Console.WriteLine("Car ID: "+ car.CarId + " => BrandID: " + car.BrandId + " => ColorID: " +
            //        car.ColorId + " => Daily Price: " + car.DailyPrice + " => Description:  " + car.Description +
            //        " => Model Year: " + car.ModelYear);
            //}



            Console.ReadLine();
        }
    }
}
