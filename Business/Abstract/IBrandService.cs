using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetBrandById(int brandId);
        void AddBrand(Brand carEntity);
        void UpdateBrand(Brand carEntity);
        void DeleteBrand(Brand carEntity);
    }
}
