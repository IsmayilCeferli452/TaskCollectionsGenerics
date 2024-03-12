using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;

namespace Task.Data
{
    public class AppDbContext
    {
        public static List<Customer> customers;

        static AppDbContext()
        {
            customers = new List<Customer>()
            {
            new Customer
            {
                Id = 1,
                FullName = "Ismayil Ceferli",
                Address = "Ehmedli",
                Age = 50,
            },
            new Customer
            {
                Id = 2,
                FullName = "Ilqar Siriyev",
                Address = "Hezi Aslanov",
                Age = 44,
            },
            new Customer
            {
                Id = 3,
                FullName = "Behruz Eliyev",
                Address = "Xalqlar Dostlugu",
                Age = 20,
            },
            new Customer
            {
                Id = 4,
                FullName = "Ayxan Dadasov",
                Address = "Neftciler",
                Age = 30,
            },
            };
        }
    }
}
