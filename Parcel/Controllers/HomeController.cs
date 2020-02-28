using Microsoft.AspNetCore.Mvc;
using ShippingCompany.Models;
using System;
using System.Collections.Generic;
using System.Numerics;
namespace ShippingCompany.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        
    }
}