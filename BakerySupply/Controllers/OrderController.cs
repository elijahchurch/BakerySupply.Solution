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

        [HttpGet("vendors/{vendorId}/orders/{orderId}")]
        public ActionResult Show(int vendorId, int orderId)
        {
            Vendor chosenVendor = Vendor.FindVendor(vendorId);
            Order chosenOrder = chosenVendor.Orders.Find(x=> x.Id == orderId);
            return View(chosenOrder);
        }

    }
}