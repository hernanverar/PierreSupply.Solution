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
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, "test description");
      //Act 
      int result = newVendor.Id;
      //Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Vendor 1";
      string name02 = "Vendor 2";
      Vendor newVendor1 = new Vendor(name01, "test description");
      Vendor newVendor2 = new Vendor(name02, "test description");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      //Act
      List<Vendor> result = Vendor.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string title = "Order 1";
      Order newOrder = new Order(title, "test description", 1, "test date");
      List<Order> newList = new List<Order> { newOrder };
      string name = "Vendor 1";
      Vendor newVendor = new Vendor(name, "test description");
      newVendor.AddOrder(newOrder);
      //Act
      List<Order> result = newVendor.Orders;
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
