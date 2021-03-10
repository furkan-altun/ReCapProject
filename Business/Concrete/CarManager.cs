using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public List<Car> GetAll()
        {
            return _carDal.GetAll(x => x.DailyPrice < 50000);
        }

        public Car GetCarById(int carId)
        {
            return _carDal.Get(x => x.Id == carId);
        }

        public void AddCar(Car carEntity)
        {
            _carDal.Add(carEntity);
        }

        public void UpdateCar(Car carEntity)
        {
            _carDal.Update(carEntity);
        }

        public void DeleteCar(Car carEntity)
        {
            _carDal.Delete(carEntity);
        }

        public List<CarDetailDto> GetAllCarsWithDetail()
        {
            return _carDal.CarListWithDetail();
        }
    }
}
