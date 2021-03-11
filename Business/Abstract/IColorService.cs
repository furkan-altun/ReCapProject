using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetColorById(int colorId);
        IResult AddColor(Color carEntity);
        IResult UpdateColor(Color carEntity);
        IResult DeleteColor(Color carEntity);
    }
}
