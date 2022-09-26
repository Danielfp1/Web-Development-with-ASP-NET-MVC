﻿using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.MySuperProperty = "This is my first app!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewCustomer(Customer postedCustomer)
        {
            Customer customer = new Customer();
            
            customer.Id = Guid.NewGuid().ToString();
            customer.Name = postedCustomer.Name;
            customer.Telephone = postedCustomer.Telephone;

            return View(customer);
        }

        public ActionResult AddCustomer()
        {
            return View();
        }
    }
}