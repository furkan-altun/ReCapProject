using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult AddBrand(Brand brandEntity)
        {
            _brandDal.Add(brandEntity);
            return new SuccessResult();
        }

        public IResult DeleteBrand(Brand brandEntity)
        {
            _brandDal.Delete(brandEntity);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetBrandById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(x => x.BrandId == brandId));
        }

        public IResult UpdateBrand(Brand brandEntity)
        {
            _brandDal.Update(brandEntity);
            return new SuccessResult();
        }
    }
}
