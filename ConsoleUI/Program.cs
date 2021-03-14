using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Linq;
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

            //HandleException();

            //UserManagerCrud();

            //CustomerManagerCrudAndDto();

            //RentalManagerCrudAndDto();
        }

        private static void RentalManagerCrudAndDto()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //List Detailed rental list
            //var result = rentalManager.GetRentalDetail();
            //foreach (var item in result.Data)
            //{
            //    Console.WriteLine($"{item.Id} - {item.CarBrand} - {item.CustomerName} - {item.RentDate} - {item.ReturnDate}");
            //}

            //List all Rental Processes
            //var result = rentalManager.GetAllRentalProcesses();
            //foreach (var item in result.Data)
            //{
            //    Console.WriteLine($"{item.Id} - {item.CustomerId} - {item.CarId} - {item.RentDate} - {item.ReturnDate}");
            //}

            //Get Rental Process
            //var result = rentalManager.GetRentalProcessById(1);
            //Console.WriteLine($"{result.Data.Id} - {result.Data.CustomerId} - {result.Data.CarId} - {result.Data.RentDate} - {result.Data.ReturnDate}");

            //Add Rental Process
            //var addedRentalProcess = new Rental
            //{
            //    CarId = 1,
            //    CustomerId = 2,
            //    RentDate = new DateTime(2021, 03, 15),
            //    ReturnDate = null
            //};
            //var allProcesses = rentalManager.GetAllRentalProcesses();
            //var addedProcesses = allProcesses.Data.FirstOrDefault(x => x.CarId == addedRentalProcess.CarId);

            //if (addedProcesses.ReturnDate == null || addedProcesses.ReturnDate == DateTime.MinValue)
            //{
            //    Console.WriteLine("Araç teslim edilmemiş.");
            //}
            //else
            //{
            //    var result = rentalManager.AddRentalProcess(addedRentalProcess);
            //    Console.WriteLine("Sonuç: " + result.Success + " | " + result.Message);
            //}


            //Update Rental Process
            //var updatedRentalProcess = new Rental
            //{
            //    Id = 2,
            //    CarId = 1,
            //    CustomerId = 2,
            //    RentDate = new DateTime(2021, 03, 15),
            //    ReturnDate = new DateTime(2021, 03, 18)
            //};
            //var result = rentalManager.UpdateRentalProcess(updatedRentalProcess);
            //Console.WriteLine("Sonuç: " + result.Success + " | " + result.Message);

            //Delete Rental Process   
            //var deletedRentalProcess = new Rental()
            //{
            //    Id = 1
            //};
            //var result = rentalManager.DeleteRentalProcess(deletedRentalProcess);
            //Console.WriteLine("Sonuç: " + result.Success + " | " + result.Message);
        }

        private static void CustomerManagerCrudAndDto()
        {
            CustomerManager userManager = new CustomerManager(new EfCustomerDal());

            //List All customer with dto from users table
            //var result = userManager.GetCustomerDetail();
            //foreach (var item in result.Data)
            //{
            //    Console.WriteLine($"{item.Id} - {item.UserFirstName} {item.UserLastName} - {item.CompanyName}");
            //}

            //List all Customers
            //var result = userManager.GetAllCustomers();
            //foreach (var item in result.Data)
            //{
            //    Console.WriteLine($"{item.Id} - {item.UserId} - {item.CompanyName}");
            //}

            //Get Customer
            //var customer = userManager.GetCustomerById(1);
            //Console.WriteLine($"{customer.Data.Id} - {customer.Data.UserId} - {customer.Data.CompanyName}");

            //Add Customer
            //var addedCustomer = new Customer
            //{
            //    UserId = 1,
            //    CompanyName = "Yemeksepeti"
            //};
            //var result = userManager.AddCustomer(addedCustomer);
            //Console.WriteLine("Sonuç: " + result.Success + " | " + result.Message);

            //Update Customer
            //var updatedCustomer = new Customer
            //{
            //    Id = 2,
            //    UserId = 1,
            //    CompanyName = "Intertech"
            //};
            //var result = userManager.UpdateCustomer(updatedCustomer);
            //Console.WriteLine("Sonuç: " + result.Success + " | " + result.Message);

            //Delete Customer   
            //var deletedCustomer = new Customer
            //{
            //    Id = 1
            //};
            //var result = userManager.DeleteCustomer(deletedCustomer);
            //Console.WriteLine("Sonuç: " + result.Success + " | " + result.Message);
        }

        private static void UserManagerCrud()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            //List all Users
            //var result = userManager.GetAllUsers();
            //foreach (var item in result.Data)
            //{
            //    Console.WriteLine($"{item.Id} - {item.FirstName} - {item.LastName} - {item.Email} - {item.Password}");
            //}

            //Get User
            //var user = userManager.GetSpecificUser(1);
            //Console.WriteLine($"{user.Data.Id} - {user.Data.FirstName} - {user.Data.LastName} - {user.Data.Email} - {user.Data.Password}");

            //Add User
            //var addedUser = new User
            //{
            //    FirstName = "Muhammet",
            //    LastName = "Altun",
            //    Email = "altun.muhammetfurkan@gmail.com",
            //    Password = "123456"
            //};
            //var result = userManager.AddUser(addedUser);
            //Console.WriteLine("Sonuç: " + result.Success +" | " + result.Message);

            //Update User
            //var updatedUser = new User
            //{
            //    Id = 3,
            //    FirstName = "Ricardo",
            //    LastName = "Quaresma",
            //    Email = "ricard@quaresma.com",
            //    Password = "12345678999"
            //};
            //var result = userManager.UpdateUser(updatedUser);
            //Console.WriteLine("Sonuç: " + result.Success + " | " + result.Message);

            //Delete User
            //var deletedUser = new User
            //{
            //    Id = 2
            //};
            //var result = userManager.DeleteUser(deletedUser);
            //Console.WriteLine("Sonuç: " + result.Success + " | " + result.Message);
        }

        private static void HandleException()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //GetAllWithDetail For Cars
            var result = carManager.GetAllCarsWithDetail();
            if (!result.Success)
            {
                Console.WriteLine("Ürünler getirilemedi");
            }
            else
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine($"{item.CarBrand} - {item.Color} - {item.Model} - {item.Description}");
                }
            }
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
