using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> CarListWithDetail()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join br in context.Brands on c.BrandId equals br.BrandId
                             join co in context.Colors on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                CarBrand = br.BrandName,
                                Color = co.ColorCode,
                                Model = c.ModelYear.ToString(),
                                Description = c.Description
                             };

                return result.ToList();
            }
        } 
    }
}
