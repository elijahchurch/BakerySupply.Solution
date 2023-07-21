using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakerySupply.Models;

namespace BakerySupply.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }
    }
}