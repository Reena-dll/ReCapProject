using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId=1, ColorId= 1, DailyPrice = 100, Description = "Konforlu Kiralık Araba", ModelYear= "2019"},
                new Car{CarId = 2, BrandId=2, ColorId= 2, DailyPrice = 150, Description = "Aile Arabası", ModelYear= "2020"},
                new Car{CarId = 3, BrandId=3, ColorId= 1, DailyPrice = 250, Description = "Yeni Model Araba", ModelYear= "2021"},
                new Car{CarId = 4, BrandId=1, ColorId= 3, DailyPrice = 150, Description = "Jip Model Araba", ModelYear= "2018"},
                new Car{CarId = 5, BrandId=2, ColorId= 2, DailyPrice = 200, Description = "Hız Tutkunları İçin Araba", ModelYear= "2017"},
                new Car{CarId = 6, BrandId=4, ColorId= 4, DailyPrice = 200, Description = "Hız Tutkunları İçin Araba", ModelYear= "2016"},
                new Car{CarId = 7, BrandId=3, ColorId= 4, DailyPrice = 100, Description = "Konforlu Kiralık Araba", ModelYear= "2020"},
                new Car{CarId = 8, BrandId=4, ColorId= 1, DailyPrice = 100, Description = "Konforlu Kiralık Araba", ModelYear= "2019"},
                new Car{CarId = 9, BrandId=1, ColorId= 2, DailyPrice = 300, Description = "Servis Arabası", ModelYear= "2019"},
                new Car{CarId = 10, BrandId=3, ColorId= 3, DailyPrice = 150, Description = "Aile Arabası", ModelYear= "2020"},
                new Car{CarId = 11, BrandId=1, ColorId= 2, DailyPrice = 300, Description = "Son Model Araba", ModelYear= "2022"},
                new Car{CarId = 12, BrandId=2, ColorId= 1, DailyPrice = 150, Description = "Jip Model Araba", ModelYear= "2020"},
                new Car{CarId = 13, BrandId=2, ColorId= 4, DailyPrice = 300, Description = "Son Model Araba", ModelYear= "2022"},
            };
        }

     

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
             Car result = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(result);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            var result = _cars.Find(c => c.CarId == id);
            return result;
        }

        public void Update(Car car)
        {
            Car result = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            result.BrandId = car.BrandId;
            result.ColorId = car.ColorId;
            result.DailyPrice = car.DailyPrice;
            result.Description = car.Description;
            result.ModelYear = car.ModelYear;
        }
    }
}
