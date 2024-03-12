using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Data;
using Task.Models;
using Task.Services.Interfaces;

namespace Task.Services
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetAll()
        {
            return AppDbContext.customers;
        }

        public Customer GetById(int? id)
        {
            return id == null ? throw new ArgumentNullException() : AppDbContext.customers.FirstOrDefault(m => m.Id == id);
        }

        public List<Customer> GetAllByFullName(string fullName)
        {
            return AppDbContext.customers.Where(m => m.FullName == fullName).ToList();
        }

        public int GetCount()
        {
            return AppDbContext.customers.Count;
        }

        public List<Customer> OrderByAge(List<Customer> customers)
        {
            return customers.OrderBy(m => m.Age).ToList();
        }
    }
}
