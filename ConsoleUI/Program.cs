using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine( $"Marka: {item.BrandId} | Renk: {item.ColorId} | Fiyat: {item.DailyPrice} | Yıl: {item.ModelYear} | Açıklama: {item.Description}");
            }

        }
    }
}
