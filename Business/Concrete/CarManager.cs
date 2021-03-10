using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

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
            throw new NotImplementedException();
        }

        public List<Car> GetCarById(int carId)
        {
            throw new NotImplementedException();
        }

        public void AddCar(Car carEntity)
        {
            throw new NotImplementedException();
        }

        public void UpdateCar(Car carEntity)
        {
            throw new NotImplementedException();
        }

        public void DeleteCar(Car carEntity)
        {
            throw new NotImplementedException();
        }
    }
}
