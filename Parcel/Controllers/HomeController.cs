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
            List<Parcel> AllParcels = Parcel.GetAll();

            return View(AllParcels);
        }

        [HttpGet("/items")]
        public ActionResult CreateItem()
        {
            return View();
        }

        [HttpGet("/parcel/new")]
        public ActionResult CreateParcelForm()
        {

            return View();
        }
        [HttpPost("/parcel")]
        public ActionResult CreateParcel(string name, string boxDescription, float dimX, float dimY, float dimZ, float boxWeight)
        {
            Parcel TempParcel = new Parcel(name, boxDescription, new Vector3(dimX, dimY, dimZ));
            TempParcel.BoxWeight = boxWeight;
            return RedirectToAction("Index");
        }
        [HttpGet("/parcel/items/new")]
        public ActionResult CreateItem(string name, string description, float weight)
        {
            Item myItem = new Item(name, description, weight);
            return RedirectToAction("Index");
        }
    }
}