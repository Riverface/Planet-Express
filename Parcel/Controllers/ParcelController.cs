using Microsoft.AspNetCore.Mvc;
using ShippingCompany.Models;
using System;
using System.Collections.Generic;
using System.Numerics;
namespace ShippingCompany.Controllers
{
    public class ParcelController : Controller
    {
        [HttpGet("/parcel")]
        public ActionResult Index()
        {
            List<Parcel> AllParcels = Parcel.GetAll();

            return View(AllParcels);
        }

        [HttpGet("/parcel/new")]
        public ActionResult CreateParcelForm()
        {
            return View();
        }

        [HttpPost("/parcel")]
        public ActionResult CreateParcel(string name, string boxDescription, float dimX, float dimY, float dimZ, float boxWeight)
        {
            Parcel TempParcel = new Parcel(name, boxDescription, new Vector3(dimX, dimY, dimZ), boxWeight);
            return RedirectToAction("index");
        }

    }
}