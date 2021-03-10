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
            throw new NotImplementedException();
        }

        public Color GetColorById(int colorId)
        {
            throw new NotImplementedException();
        }

        public void AddColor(Color carEntity)
        {
            throw new NotImplementedException();
        }

        public void UpdateColor(Color carEntity)
        {
            throw new NotImplementedException();
        }

        public void DeleteColor(Color carEntity)
        {
            throw new NotImplementedException();
        }
    }
}
