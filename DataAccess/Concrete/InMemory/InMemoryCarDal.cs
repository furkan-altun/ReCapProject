using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, ColorId = 1, BrandId = 1, DailyPrice = 1000, ModelYear = 2017, Description = "Spor araba"},
                new Car{Id = 2, ColorId = 2, BrandId = 3, DailyPrice = 5000, ModelYear = 2020, Description = "Günlük araba"},
                new Car{Id = 3, ColorId = 4, BrandId = 2, DailyPrice = 3000, ModelYear = 2019, Description = "Ticari araba"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car removedCar = _cars.FirstOrDefault(x => x.Id == car.Id);
            _cars.Remove(removedCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(x => x.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _cars.Where(x => x.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car updatedItem = _cars.FirstOrDefault(x => x.Id == car.Id);
            updatedItem.ColorId = car.ColorId;
            updatedItem.BrandId = car.BrandId;
            updatedItem.DailyPrice = car.DailyPrice;
            updatedItem.ModelYear = car.ModelYear;
            updatedItem.Description = car.Description;
        }
    }
}
