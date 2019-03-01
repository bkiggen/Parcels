using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;
using System.Collections.Generic;
using System;

namespace Parcels.Tests
{
  [TestClass]
  public class BoxTest : IDisposable
  {
    public void Dispose()
    {
      Box.ClearAll();
    }
    [TestMethod]
    public void BoxConstructor_CreatesInstanceOfBox_Box()
    {
      Box newBox = new Box("4", "2", "3", "12");
      Assert.AreEqual(typeof(Box), newBox.GetType());
    }
    [TestMethod]
    public void GetHeight_ReturnsHeight_Int()
    {
      Box newBox = new Box("4", "2", "3", "12");
      int result = newBox.GetHeight();
      Assert.AreEqual(3, result);
    }
    [TestMethod]
    public void Volume_ReturnsVolume_Int()
    {
      Box newBox = new Box("4", "2", "3", "12");
      int result = newBox.Volume();
      Assert.AreEqual(24, result);
    }
    [TestMethod]
    public void ShippingCost_ReturnsShippingCost_Int()
    {
      Box newBox = new Box("4", "2", "3", "12");
      int result = newBox.ShippingCost();
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void GetAll_ReturnsBoxes_BoxList()
    {
      //Arrange
      Box newBox1 = new Box("4", "2", "3", "12");
      Box newBox2 = new Box("2", "2", "3", "123");
      List<Box> newList = new List<Box> { newBox1, newBox2 };
      Console.WriteLine("here" + newList.Count);
      Console.WriteLine("you go" + Box.GetAll().Count);
      //Act
      List<Box> result = Box.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
