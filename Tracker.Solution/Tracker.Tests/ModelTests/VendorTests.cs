using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
  [TestClass]
  public class VendorTests  
  {

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Name", "Address");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Suzie's Cafe";

      //Act
      Vendor newVendor = new Vendor(name, "Address");
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetAddress_SetAddress_String()
    {
      //Arrange
      string address = "13050 Borden Ave";
      Vendor newVendor = new Vendor("Suzie's Cafe", address);

      //Act
      string updatedAddress = "23050 Borden Blvd";
      newVendor.Address = updatedAddress;
      string result = newVendor.Address;

      //Assert
      Assert.AreEqual(updatedAddress, result);
    }

  }
}
