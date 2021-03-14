using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<RentalDetailDto>> GetRentalDetail();
        IDataResult<List<Rental>> GetAllRentalProcesses();
        IDataResult<Rental> GetRentalProcessById(int userId);
        IResult AddRentalProcess(Rental entity);
        IResult UpdateRentalProcess(Rental entity);
        IResult DeleteRentalProcess(Rental entity);
    }
}
