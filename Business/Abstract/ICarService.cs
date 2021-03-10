using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetCarById(int carId);
        void AddCar(Car carEntity);
        void UpdateCar(Car carEntity);
        void DeleteCar(Car carEntity);
        List<CarDetailDto> GetAllCarsWithDetail();
    }
}
