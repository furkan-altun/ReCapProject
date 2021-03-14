using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<List<User>> GetAllUsers()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetSpecificUser(int userId)
        {
            return new DataResult<User>(_userDal.Get(x => x.Id == userId),true);
        }

        public IResult AddUser(User entity)
        {
            try
            {
                _userDal.Add(entity);
                return new SuccessResult("ürün eklendi");
            }
            catch (Exception e)
            {
                return new ErrorResult("Hatalı kayıt");
            }
            
        }

        public IResult UpdateUser(User entity)
        {
            _userDal.Update(entity);
            return new SuccessResult();
        }

        public IResult DeleteUser(User entity)
        {
            _userDal.Delete(entity);
            return new Result(true);
        }
    }
}
