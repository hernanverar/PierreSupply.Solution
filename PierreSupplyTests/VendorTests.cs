using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreSupply.Models;
using System.Collections.Generic;
using System;

namespace PierreSupply.Tests
{
  [TestClass]
  public class VendorTests 
  public void Disposable()
  {
    Vendor.ClearAll();
  }
  {
        [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

  }
}