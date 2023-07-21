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
    }
}