using MvcLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLearning.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        public ViewResult Index()
        {
            return View(GetCustomers());
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer(){ Id=1, Name ="John Smith" },
                new Customer(){ Id=2, Name ="Mary Williams" }
            };
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(q => q.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}