using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;

        public InMemoryColorDal()
        {
            _colors = new List<Color>
            {
                new Color{ColorId = 1, ColorCode = "#000000"},
                new Color{ColorId = 2, ColorCode = "#FFFFFF"},
                new Color{ColorId = 3, ColorCode = "#FF0000"},
                new Color{ColorId = 4, ColorCode = "#00FF00"},
            };
        }

        public List<Color> GetAll()
        {
            return _colors;
        }
    }
}
