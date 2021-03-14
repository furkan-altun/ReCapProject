using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental,CarRentalContext> , IRentalDal
    {
        public List<RentalDetailDto> GetDetailedRentalList()
        {
            using (CarRentalContext context = new CarRentalContext())
            {

                var result = from r in context.Rentals
                             join ca in context.Cars on r.CarId equals ca.Id
                             join br in context.Brands on ca.BrandId equals br.BrandId
                             join cus in context.Customers on r.CustomerId equals cus.Id
                             join us in context.Users on cus.UserId equals us.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarBrand = br.BrandName,
                                 CustomerName = us.FirstName + " "+ us.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };

                return result.ToList();

            }
        }
    }
}
