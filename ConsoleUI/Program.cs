using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //Araçları listeleme
            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.Description);
            //}

            //Exception case
            brandManager.AddBrand(new Brand { BrandId = 4, BrandName = "a" });
            //Marka ekleme
            brandManager.AddBrand(new Brand { BrandId = 4, BrandName = "bugatti" });

            //exception case
            carManager.AddCar(new Car { Id = 9, BrandId = 1, ColorId = 1, DailyPrice = 0, Description = "hatalı case", ModelYear = 2000 });

            //araba ekleme
            carManager.AddCar(new Car { Id = 10, BrandId = 1, ColorId = 1, DailyPrice = 110, Description = "fluence", ModelYear = 2000 });
        }
    }
}
