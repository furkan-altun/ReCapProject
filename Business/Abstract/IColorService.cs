using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetColorById(int colorId);
        void AddColor(Color carEntity);
        void UpdateColor(Color carEntity);
        void DeleteColor(Color carEntity);
    }
}
