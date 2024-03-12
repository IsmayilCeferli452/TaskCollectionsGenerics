

using Task.Controllers;
using Task.Data;
using Task.Services;


//foreach (var item in AppDbContext.customers)
//{
//    Console.WriteLine(item.FullName);
//}

CustomerController customerController = new CustomerController();

//customerController.GetAll();
//customerController.GetById();
//customerController.GetAllByFullName();
//customerController.GetCount();
customerController.OrderByAge();






