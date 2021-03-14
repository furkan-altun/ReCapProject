using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private readonly IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetail()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetDetailedRentalList());
        }

        public IDataResult<List<Rental>> GetAllRentalProcesses()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetRentalProcessById(int rentalId)
        {
            return new DataResult<Rental>(_rentalDal.Get(x => x.Id == rentalId), true);
        }

        public IResult AddRentalProcess(Rental entity)
        {
            try
            {
                _rentalDal.Add(entity);
                return new SuccessResult("ürün eklendi");
            }
            catch (Exception e)
            {
                return new ErrorResult("Hatalı kayıt");
            }

        }

        public IResult UpdateRentalProcess(Rental entity)
        {
            _rentalDal.Update(entity);
            return new SuccessResult();
        }

        public IResult DeleteRentalProcess(Rental entity)
        {
            _rentalDal.Delete(entity);
            return new Result(true);
        }
    }
}
