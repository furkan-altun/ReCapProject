using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarById(int carId);
        void AddCar(Car carEntity);
        void UpdateCar(Car carEntity);
        void DeleteCar(Car carEntity);
    }
}
