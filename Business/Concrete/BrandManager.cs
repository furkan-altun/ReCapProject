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
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void AddBrand(Brand brandEntity)
        {
            if (brandEntity.BrandName.Length < 2)
            {
                Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır");
            }
            else
            {
                _brandDal.Add(brandEntity);
                Console.WriteLine(brandEntity.BrandName + " eklendi");
            }            
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }
    }
}
