using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreSupply.Models;
using System.Collections.Generic;
using System;

namespace PierreSupply.Tests
{
  [TestClass]
  public class OrderTests 
  public void Disposable()
  {
    Order.ClearAll();
  }
  {
        [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test Order");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

  }
}