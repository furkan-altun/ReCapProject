using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetBrandById(int brandId);
        IResult AddBrand(Brand carEntity);
        IResult UpdateBrand(Brand carEntity);
        IResult DeleteBrand(Brand carEntity);
    }
}
