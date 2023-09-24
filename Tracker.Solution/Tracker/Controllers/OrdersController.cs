using Microsoft.AspNetCore.Mvc;
using Tracker.Models;
using System.Collections.Generic;

namespace Tracker.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }


  }
}