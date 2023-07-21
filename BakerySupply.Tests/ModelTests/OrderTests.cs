using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakerySupply.Models;
using System.Collections.Generic;
using System;

namespace BakerySupply.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.IdCounter = 0;
        }
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

        [TestMethod]
        public void OrderConstructor_ReturnsDate_String()
        {
            Order testOrder = new Order("test", "5 bagels", 14, "7/6/23");
            Assert.AreEqual("7/6/23", testOrder.Date);
        }

        [TestMethod]
        public void IdCounterField_IdCounterFieldCanBeSetWithConstructor_Int()
        {
            Order testOrder = new Order("test", "5 bagels", 14, "7/6/23");
            Assert.AreEqual(1, Order.IdCounter);
        }

        [TestMethod]
        public void OrderConstructor_ReturnsId_Int()
        {
            Order testOrder = new Order("test", "5 bagels", 14, "7/6/23");
            Assert.AreEqual(1, testOrder.Id);
        }


    }
}