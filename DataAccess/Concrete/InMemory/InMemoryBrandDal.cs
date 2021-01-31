using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;

        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{BrandId = 1, BrandName ="Mercedes"},
                new Brand{BrandId = 2, BrandName ="Bmw"},
                new Brand{BrandId = 3, BrandName ="Ferrari"}
            };
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }
    }
}
