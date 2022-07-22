using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      // Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceofOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDetails_ReturnsDetails_String()
    {
      string details = "4 loafs of bread";

      Order newOrder = new Order(details);
      string result = newOrder.Details;

      Assert.AreEqual(details, result);
    }

  }
}