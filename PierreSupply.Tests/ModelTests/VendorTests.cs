using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreSupply.Models;
using System.Collections.Generic;
using System;

namespace PierreSupply.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  public void Dispose()
  {
    Vendor.ClearAll();
  }

  [TestMethod]
  public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
  {
    Vendor newVendor = new Vendor("test name", "test desc");
    Assert.AreEqual(typeof(Vendor), newVendor.GetType());
  }

  [Testmethod]
  public void GetName_ReturnName_String()
  {
    string name = "Suzie's Cafe";
    Vendor = newVendor = new Vendor(name, "test desc");
    string result = newVendor.Name;
    Assert.AreEqual(name, result);
  }

}
