using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakerySupply.Models;
using System.Collections.Generic;
using System;

namespace BakerySupply.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.IdCounter = 0;
            Vendor.ClearAll();
        }
        [TestMethod]
        public void VendorConstructor_InstantiateVendorClass_Vendor()
        {
            Vendor testVendor = new Vendor("test", "Cornerstore that orders bread");
            Assert.AreEqual(typeof(Vendor), testVendor.GetType());
        }

        [TestMethod]
        public void VendorConstructor_ReturnsName_String()
        {
            Vendor testVendor = new Vendor("test", "Cornerstore that orders bread");
            Assert.AreEqual("test", testVendor.Name);
        }

        [TestMethod]
        public void VendorConstructor_ReturnsDescription_String()
        {
            Vendor testVendor = new Vendor("test", "Cornerstore that orders bread");
            Assert.AreEqual("Cornerstore that orders bread", testVendor.Description);
        }

        [TestMethod]
        public void IdCounterField_IdCounterFieldCanBeSetWithConstructor_Int()
        {
            Vendor testVendor = new Vendor("test", "Cornerstore that orders bread");
            Assert.AreEqual(1, Vendor.IdCounter);
        }

        [TestMethod]
        public void VendorConstructor_ReturnsId_Int()
        {
            Vendor testVendor = new Vendor("test", "Cornerstore that orders bread");
            Vendor vendor2 = new Vendor("Coffee Shop", "Shop located downtown");
            Assert.AreEqual(2, vendor2.Id);
        }

        [TestMethod]
        public void VendorConstructor_ReturnsOrderList_List()
        {
            Vendor testVendor = new Vendor("test", "Cornerstore that orders bread");
            Order testOrder = new Order("test", "5 bagels", 14, "7/6/23");
            testVendor.Orders.Add(testOrder);            
            Assert.AreEqual(testOrder, testVendor.Orders[0]);
        }

        [TestMethod]
        public void GetAll_ReturnsAllVendorObjects_VendorList()
        {
            Vendor testVendor = new Vendor("test", "Cornerstore that orders bread");
            Vendor vendor2 = new Vendor("Coffee Shop", "Shop located downtown");
            List<Vendor> expectedList = new List<Vendor> { testVendor, vendor2};
            List <Vendor> resultList = Vendor.GetAll();
            CollectionAssert.AreEqual(expectedList, resultList);
        }


    }
}