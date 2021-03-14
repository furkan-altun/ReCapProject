using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAllUsers();
        IDataResult<User> GetSpecificUser(int userId);
        IResult AddUser(User entity);
        IResult UpdateUser(User entity);
        IResult DeleteUser(User entity);
    }
}
