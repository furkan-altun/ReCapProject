using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetCarById(int carId);
        IResult AddCar(Car carEntity);
        IResult UpdateCar(Car carEntity);
        IResult DeleteCar(Car carEntity);
        IDataResult<List<CarDetailDto>> GetAllCarsWithDetail();
    }
}
