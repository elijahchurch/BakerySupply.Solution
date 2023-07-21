using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakerySupply.Models;
using System.Collections.Generic;
using System;

namespace BakerySupply.Tests
{
    [TestClass]
    public class OrderTests
    {
        // Test methods go here
        [TestMethod]
        public void Orderconstructor_InstantiateOrderClass_Order()
        {
        Order testOrder = new Order("test", "5 bagels", 14.50, "7/6/23");
        Assert.AreEqual(typeof(Order), testOrder.GetType());
        }
    }
}