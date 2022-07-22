using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;


namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests: IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceofVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);
      string result = newVendor.vendorName;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_VendorsInstantiaeWithAnIdAndGetterReturns_Int()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorsOrders_VendorList()
    {
      string name01 = "Suzies Cafe";
      string name02 = "Franks Diner";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);
      List<Vendor> newList = new List<Vendor> {newVendor1, newVendor2};

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderwithVendor_OrderList()
    {
      string order1 = "2 dozen pastries";
      Order newOrder = new Order(order1);
      List<Order> newList = new List<Order> {newOrder};
      string name = "Franks Diner";
      Vendor newVendor = new Vendor(name);
      newVendor.AddOrder(newOrder);
    }
  }
}
