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
      Order.ClearAll();
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

    [TestMethod]
    public void SetDetails_SetDetails_String()
    {
      string details = "4 loafs of bread";
      Order newOrder = new Order(details);
      string updatedDetails = "6 loafs of bread";
      newOrder.Details = updatedDetails;
      string result = newOrder.Details;
      Assert.AreEqual(updatedDetails, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    { 
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string details01 = "4 loafs of bread";
      string details02 = "2 dozen pastries";
      Order newOrder1 = new Order(details01);
      Order newOrder2 = new Order(details02);
      List<Order> newList = new List<Order> {newOrder1, newOrder2};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstatiateWithAnIdAndGetterReturns_Id()
    {
      string details = "4 loafs of bread";
      Order newOrder = new Order(details);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectItem_Item()
    {
      string details01 = "4 loafs of bread";
      string details02 = "2 dozen patries";
      Order newOrder1 = new Order(details01);
      Order newOrder2 = new Order(details02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);

    }
  }
}