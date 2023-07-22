using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreSupply.Models;
using System.Collections.Generic;
using System;

namespace PierreSupply.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      // Arrange
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, "test description");
      // Act
      string result = newVendor.Name;
      // Assert
      Assert.AreEqual(name, result);
    }
  }
}
