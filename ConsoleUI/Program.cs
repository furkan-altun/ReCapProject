using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore.Storage;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarManagerCrud();

            //BrandManagerCrud();

            //ColorManagerCrud();
        }

        private static void ColorManagerCrud()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //GetAll for colors
            //foreach (var item in colorManager.GetAll())
            //{
            //    Console.WriteLine($"{item.ColorId} - {item.ColorCode}");
            //}

            //GetColorById for colors
            //var selectedColor = colorManager.GetColorById(1);
            //Console.WriteLine($"{selectedColor.ColorId} - {selectedColor.ColorCode}");

            //AddColor Example
            //Color addedColor = new Color
            //{
            //    ColorCode = "Test color"
            //};
            //colorManager.AddColor(addedColor);

            //UpdateColor Example
            //Color updatedColor = new Color {ColorId = 8, ColorCode = "Updated Color"};
            //colorManager.UpdateColor(updatedColor);

            //DeletedColor Example
            //Color deletedColor = new Color {ColorId = 8};
            //colorManager.DeleteColor(deletedColor);
        }

        private static void BrandManagerCrud()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //GetAll for brand
            //foreach (var item in brandManager.GetAll())
            //{
            //    Console.WriteLine($"{item.BrandId} - {item.BrandName}");
            //}

            //GetById example
            //var brandItem = brandManager.GetBrandById(3);
            //Console.WriteLine($"{brandItem.BrandId} - {brandItem.BrandName}");

            //Added brand Example
            //var addedBrand = new Brand
            //{
            //    BrandName = "Added brand example 2"
            //};
            //brandManager.AddBrand(addedBrand);

            //Updated brand Example
            //var updatedBrand = new Brand
            //{
            //    BrandId = 6,
            //    BrandName = "Updated brand"
            //};
            //brandManager.UpdateBrand(updatedBrand);

            //Deleted brand Example
            //var deletedBrand = new Brand
            //{
            //    BrandId = 6
            //};
            //brandManager.DeleteBrand(deletedBrand);
        }

        private static void CarManagerCrud()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //GetAll For Cars
            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine($"{item.Id} - {item.BrandId} - {item.ColorId} - {item.DailyPrice} - {item.ModelYear} - {item.ModelYear}");
            //}

            //GetAllWithDetail For Cars
            //foreach (var item in carManager.GetAllCarsWithDetail())
            //{
            //    Console.WriteLine($"{item.CarBrand} - {item.Color} - {item.Model} - {item.Description}");
            //}

            //AddCar Example
            //var addedCar = new Car
            //{
            //    BrandId = 3,
            //    ColorId = 6,
            //    ModelYear = 2004,
            //    DailyPrice = 1213,
            //    Description = "Araç test for added car method"
            //};
            //carManager.AddCar(addedCar);

            //UpdateCar Example
            //var updatedCar = new Car
            //{
            //    Id = 5,
            //    DailyPrice = 999,
            //    Description = "Araç test for added car updated"
            //};
            //carManager.UpdateCar(updatedCar);

            //DeleteCar Example
            //var deletedCar = new Car
            //{
            //    Id = 7
            //};
            //carManager.DeleteCar(deletedCar);

            Console.ReadKey();
        }
    }
}
