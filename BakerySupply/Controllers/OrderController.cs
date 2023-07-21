using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakerySupply.Models;

namespace BakerySupply.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("/vendors/{id}/orders/new")]
        public ActionResult New(int id)
        {
            Vendor chosenVendor = Vendor.FindVendor(id);
            return View(chosenVendor);
        }

    }
}