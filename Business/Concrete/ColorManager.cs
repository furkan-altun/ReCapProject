using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private readonly IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetColorById(int colorId)
        {
            return new DataResult<Color>(_colorDal.Get(x => x.ColorId == colorId),true);
        }

        public IResult AddColor(Color colorEntity)
        {
            _colorDal.Add(colorEntity);
            return new Result(true);
        }

        public IResult UpdateColor(Color colorEntity)
        {
            _colorDal.Update(colorEntity);
            return new SuccessResult("Ürün eklendi");
        }

        public IResult DeleteColor(Color colorEntity)
        {
            if (colorEntity.ColorId == 1)
            {
                return new ErrorResult("Bu ürün silinemez");
            }

            _colorDal.Delete(colorEntity);
            return new SuccessResult();
        }
    }
}
