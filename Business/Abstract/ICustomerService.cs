using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAllCustomers();
        IDataResult<Customer> GetCustomerById(int userId);
        IResult AddCustomer(Customer entity);
        IResult UpdateCustomer(Customer entity);
        IResult DeleteCustomer(Customer entity);
        IDataResult<List<CustomerDetailDto>> GetCustomerDetail();
    }
}
