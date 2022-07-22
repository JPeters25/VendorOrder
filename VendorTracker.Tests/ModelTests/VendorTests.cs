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
      // Vendor.ClearAll();
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
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
  }
}
