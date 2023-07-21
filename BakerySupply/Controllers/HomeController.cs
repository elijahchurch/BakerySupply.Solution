using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakerySupply.Models;

namespace BakerySupply.Controllers
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