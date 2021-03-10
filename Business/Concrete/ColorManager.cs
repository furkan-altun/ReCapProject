using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private readonly IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return  _colorDal.GetAll();
        }

        public Color GetColorById(int colorId)
        {
            return _colorDal.Get(x => x.ColorId == colorId);
        }

        public void AddColor(Color colorEntity)
        {
            _colorDal.Add(colorEntity);
        }

        public void UpdateColor(Color colorEntity)
        {
            _colorDal.Update(colorEntity);
        }

        public void DeleteColor(Color colorEntity)
        {
            _colorDal.Delete(colorEntity);
        }
    }
}
