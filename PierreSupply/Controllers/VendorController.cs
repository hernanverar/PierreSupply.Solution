using Microsoft.AspNetCore.Mvc;
using PierreSupply.Models;
using System.Collections.Generic;

namespace PierreSupply.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendor = Vendor.GetAll();
      return View(allVendor);
    }
  }  
} 