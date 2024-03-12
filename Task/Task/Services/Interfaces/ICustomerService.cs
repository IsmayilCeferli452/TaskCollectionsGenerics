using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;

namespace Task.Services.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int? id);
        List<Customer> GetAllByFullName(string name);
        int GetCount();
        public List<Customer> OrderByAge(List<Customer> customers);
    }
}
