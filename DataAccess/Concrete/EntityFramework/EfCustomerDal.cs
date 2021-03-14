using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer,CarRentalContext>,ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerWithDetail()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from us in context.Users
                             join c in context.Customers on us.Id equals c.UserId
                             select new CustomerDetailDto
                             {
                                 Id = c.Id,
                                 UserFirstName = us.FirstName,
                                 UserLastName = us.LastName,
                                 CompanyName = c.CompanyName
                             };

                return result.ToList();

            }
        }
    }
}
