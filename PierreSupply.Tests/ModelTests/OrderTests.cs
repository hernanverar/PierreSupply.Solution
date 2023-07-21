using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreSupply.Models;
using System.Collections.Generic;
using System;

namespace PierreSupply.Tests
{
  [TestClass]
  public class OrderTests: IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
  
        [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("bread", "flour");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
  
}