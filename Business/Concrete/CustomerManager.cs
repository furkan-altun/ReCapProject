using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetail()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerWithDetail());
        }

        public IDataResult<List<Customer>> GetAllCustomers()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetCustomerById(int customerId)
        {
            return new DataResult<Customer>(_customerDal.Get(x => x.Id == customerId), true);
        }

        public IResult AddCustomer(Customer entity)
        {
            try
            {
                _customerDal.Add(entity);
                return new SuccessResult("ürün eklendi");
            }
            catch (Exception e)
            {
                return new ErrorResult("Hatalı kayıt");
            }

        }

        public IResult UpdateCustomer(Customer entity)
        {
            _customerDal.Update(entity);
            return new SuccessResult();
        }

        public IResult DeleteCustomer(Customer entity)
        {
            _customerDal.Delete(entity);
            return new Result(true);
        }
    }
}
