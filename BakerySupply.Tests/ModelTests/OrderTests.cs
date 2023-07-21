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
        public void OrderConstructor_InstantiateOrderClass_Order()
        {
            Order testOrder = new Order("test", "5 bagels", 14, "7/6/23");
            Assert.AreEqual(typeof(Order), testOrder.GetType());
        }

        [TestMethod]
        public void OrderConstructor_ReturnsName_String()
        {
            Order testOrder = new Order("test", "5 bagels", 14, "7/6/23");
            Assert.AreEqual("test", testOrder.Name);
        }

        [TestMethod]
        public void OrderConstructor_ReturnsDescription_String()
        {
            Order testOrder = new Order("test", "5 bagels", 14, "7/6/23");
            Assert.AreEqual("5 bagels", testOrder.Description);
        }

        [TestMethod]
        public void OrderConstructor_ReturnsPrice_Int()
        {
            Order testOrder = new Order("test", "5 bagels", 14, "7/6/23");
            Assert.AreEqual(14, testOrder.Price);
        }
    }
}