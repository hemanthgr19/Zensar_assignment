using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAssign1.Models;

namespace MvcAssign1.Controllers
{
    public class CustomerController : Controller
    {
       
        NorthwindEntities ne = new NorthwindEntities();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        //Getting Customers who are residing in Germany
        public ActionResult Cust_Res_Germany()
        {
            List<string> Cust = (from g in ne.Customers
                                 where g.Country == "Germany"
                                 select g.ContactName).ToList();
            return View(Cust);
        }
        //Getting Customer details whose customer id is 10248
        public ActionResult Cust_With_OrderID()
        {
            List<Customer> CUST = (from r in ne.Customers
                                   join o in ne.Orders
           on r.CustomerID equals o.CustomerID
                                   where o.OrderID == 10248
                                   select r).ToList();
            return View(CUST);
        }
    }
}
