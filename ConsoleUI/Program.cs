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
            //CarManager carManager = new CarManager(new EfCarDal());
            //ProductTest(carManager);
            //ColorManager();
            //BrandManager();
            //GetCarDetailDto();
            //RentalTest();
        }

        private static void RentalTest()
        {
            Rental rental = new Rental();
            rental.CarId = 1;
            rental.CustomerId = 1;
            rental.RentDate = new DateTime(2022, 07, 19);
            rental.ReturnDate = new DateTime(2022, 07, 20);


            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //rentalManager.Add(rental);
            foreach (var item in rentalManager.GetAll().Data)
            {
                Console.WriteLine(item.CarId);
            }
            Console.ReadLine();
        }

        private static void BrandManager()
        {
            Brand brand1 = new Brand();
            brand1.BrandName = "Ferrari";
            brand1.BrandId = 9;

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(brand1);
            brandManager.Delete(brand1);
            foreach (var item in brandManager.GetAll().Data)
            {
                Console.WriteLine(item.BrandId + " " + item.BrandName);
            }
            Console.WriteLine(brandManager.GetById(2).Data.BrandName);
        }

        private static void ColorManager()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color1 = new Color();
            color1.ColorName = "Yeşil";
            color1.ColorId = 8;

            //colorManager.Add(color1);
            //colorManager.Update(color1);
            //colorManager.Delete(color1);
            foreach (var item in colorManager.GetAll().Data)
            {
                Console.WriteLine(item.ColorId + " " + item.ColorName);
            }
            Console.WriteLine(colorManager.GetById(2).Data.ColorName);
        }

        private static void GetCarDetailDto()
        {
            CarManager carManager2 = new CarManager(new EfCarDal(),new BrandManager(new EfBrandDal()));

            foreach (var item in carManager2.GetCarDetailDto().Data)
            {
                Console.WriteLine("{0} => {1} => {2} => {3}", item.Name, item.BrandName, item.ColorName, item.DailyPrice);
            }
        }

        private static void ProductTest(CarManager carManager)
        {
            //Car car1 = new Car() { ColorId = 2, BrandId = 2, DailyPrice = 10, Description = "asdasdsa", ModelYear = "2000", Name = "a", };
            //carManager.Add(car1);
            CarManager carManager3 = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));
            //carManager3.Add(new Car { Name = "GT-R R35", BrandId = 1, ColorId = 1, ModelYear = "2020", DailyPrice = 300, Description = "Mükemmel Bir Araba" });
            //carManager3.Update(new Car { CarId = 1002, Name = "GT-R R35", BrandId = 1, ColorId = 1, ModelYear = "2019", DailyPrice = 400, Description = "Dehşet Bir Araba" });
            //carManager3.Delete(new Car { CarId = 1002 });

            foreach (Car car in carManager.GetAll().Data)
            {
                Console.WriteLine("{0} => {1} => {2} => {3} => {4} => {5} => {6}"
                    , car.CarId, car.Name, car.BrandId, car.ColorId, car.DailyPrice, car.Description, car.ModelYear);
            }

            Console.WriteLine("Marka ID'e Göre Getir****************");
            foreach (Car car in carManager.GetCarsByBrandId(2).Data)
            {
                Console.WriteLine("{0} => {1} => {2} => {3} => {4} => {5} => {6}"
                    , car.CarId, car.Name, car.BrandId, car.ColorId, car.DailyPrice, car.Description, car.ModelYear);
            }

            Console.WriteLine("Rengine Göre Getir****************");
            foreach (Car car in carManager.GetCarsByColorId(2).Data)
            {
                Console.WriteLine("{0} => {1} => {2} => {3} => {4} => {5} => {6}"
                     , car.CarId, car.Name, car.BrandId, car.ColorId, car.DailyPrice, car.Description, car.ModelYear);
            }

            Console.WriteLine("Fiyat Aralığına Göre Getir****************");
            foreach (Car car in carManager.GetCarsByDailyPrice(200, 300).Data)
            {
                Console.WriteLine("{0} => {1} => {2} => {3} => {4} => {5} => {6}"
                     , car.CarId, car.Name, car.BrandId, car.ColorId, car.DailyPrice, car.Description, car.ModelYear);
            }



            //foreach (Car car in carManager.GetAll())
            //{
            //    Console.WriteLine("Car ID: "+ car.CarId + " => BrandID: " + car.BrandId + " => ColorID: " +
            //        car.ColorId + " => Daily Price: " + car.DailyPrice + " => Description:  " + car.Description +
            //        " => Model Year: " + car.ModelYear);
            //}
        }
    }
}
