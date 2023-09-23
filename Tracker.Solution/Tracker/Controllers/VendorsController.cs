using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tracker.Models;

namespace Tracker.Controllers
{
    public class VendorsController : Controller
    {
      [HttpGet("/vendors")]
      public ActionResult Index()
      {
        List<Vendor> allVendors = Vendor.GetAll();
        return View(allVendors);
      }    

        
      [HttpGet("/vendors/new")]
      public ActionResult CreateVendorForm()
      {
        List<Vendor> allVendors = Vendor.GetAll();
        return View(allVendors);   
      }

      [HttpPost("/vendors")]
      public ActionResult Create(string name, string address)
      {
        Vendor newVendor = new Vendor(name, address);
        return RedirectToAction("Index");
      }

    }
}