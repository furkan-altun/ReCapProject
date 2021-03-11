using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Core.Utilities.Results;
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


        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.DailyPrice < 50000));
        }

        public IDataResult<Car> GetCarById(int carId)
        {
            if (DateTime.Now.Hour == 15)
            {
                return new ErrorDataResult<Car>("Sistem bakımda");
            }
            return new SuccessDataResult<Car>(_carDal.Get(x => x.Id == carId));
        }

        public IResult AddCar(Car carEntity)
        {
            if (DateTime.Now.Hour == 15)
            {
                return new ErrorResult("Sistem bakımda");
            }

            _carDal.Add(carEntity);
            return new SuccessResult("Ürün eklendi");
        }

        public IResult UpdateCar(Car carEntity)
        {
            _carDal.Update(carEntity);
            return new SuccessResult();
        }

        public IResult DeleteCar(Car carEntity)
        {
            _carDal.Delete(carEntity);
            return new Result(true);
        }

        public IDataResult<List<CarDetailDto>> GetAllCarsWithDetail()
        {
            return new DataResult<List<CarDetailDto>>(_carDal.CarListWithDetail(),true);
        }
    }
}
