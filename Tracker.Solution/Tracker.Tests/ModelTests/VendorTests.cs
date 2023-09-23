using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
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
      Vendor newVendor = new Vendor("Name", "Address");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Suzie's Cafe";

      Vendor newVendor = new Vendor(name, "Address");
      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetAddress_SetAddress_String()
    {
      string address = "13050 Borden Ave";
      Vendor newVendor = new Vendor("Suzie's Cafe", address);

      string updatedAddress = "23050 Borden Blvd";
      newVendor.Address = updatedAddress;
      string result = newVendor.Address;

      Assert.AreEqual(updatedAddress, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newList = new List<Vendor> { };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Suzie's Cafe";
      string name02 = "Kool Kafe";
      Vendor newVendor1 = new Vendor(name01, "address");
      Vendor newVendor2 = new Vendor(name02, "address");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
  public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string title = "Suzie's Order";
      Order newOrder = new Order(title);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Suzie's Cafe";
      Vendor newVendor = new Vendor(name, "address");
      newVendor.AddItem(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

  }
}
