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
        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string name, string description)
        {
            Vendor newVendor = new Vendor(name, description);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Vendor chosenVendor = Vendor.FindVendor(id);
            return View(chosenVendor);
        }

        [HttpPost("/vendors/{id}/orders")]
        public ActionResult Create(string name, string description, int cost, string date, int id)
        {
            Order newOrder = new Order(name, description, cost, date);
            Vendor chosenVendor = Vendor.FindVendor(id);
            chosenVendor.AddOrder(newOrder);
            return View("Show", chosenVendor);
        }

        [HttpGet("/vendors/{id}/edit")]
        public ActionResult Edit(int id)
        {
            Vendor chosenVendor = Vendor.FindVendor(id);
            return View(chosenVendor);
        }

        [HttpPost("/vendors/{id}")]
        public ActionResult Patch(string name, string description, int id)
        {
            Vendor chosenVendor = Vendor.FindVendor(id);
            chosenVendor.Name = name;
            chosenVendor.Description = description;
            return View("Show", chosenVendor);
        }

        [HttpPost("/vendors/{id}/delete")]
        public ActionResult Delete(int id)
        {
            Vendor chosenVendor = Vendor.FindVendor(id);
            Vendor.Delete(chosenVendor);
            return RedirectToAction("Index");
        }

    }
}