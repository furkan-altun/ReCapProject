using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void AddBrand(Brand brandEntity)
        {
            _brandDal.Add(brandEntity);
        }

        public void DeleteBrand(Brand brandEntity)
        {
            _brandDal.Delete(brandEntity);   
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetBrandById(int brandId)
        {
            return _brandDal.Get(x => x.BrandId == brandId);
        }

        public void UpdateBrand(Brand brandEntity)
        {
            _brandDal.Update(brandEntity);
        }
    }
}
