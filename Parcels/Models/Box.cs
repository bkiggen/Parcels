using System;
using System.Collections.Generic;

namespace Parcels.Models
{
    public class Box
    {
      private int _length;
      private int _width;
      private int _height;
      private int _weight;
      private static List<Box> _instances = new List<Box> { };

      public Box(string length, string width, string height, string weight)
      {
        _length = int.Parse(length);
        _width = int.Parse(width);
        _height = int.Parse(height);
        _weight = int.Parse(weight);
        _instances.Add(this);
      }

      public void SetLength(int length)
      {
        _length = length;
      }
      public void Setwidth(int width)
      {
        _width = width;
      }
      public void SetHeight(int height)
      {
        _height = height;
      }
      public void SetWeight(int weight)
      {
        _weight = weight;
      }
      public int GetLength()
      {
          return _length;
      }
      public int Getwidth()
      {
          return _width;
      }
      public int GetHeight()
      {
          return _height;
      }
      public int GetWeight()
      {
          return _weight;
      }
      public static List<Box> GetAll()
      {
        return _instances;
      }

      public int Volume()
      {
        return _length * _width * _height;
      }

      public int ShippingCost()
      {
        return _length * _width * _height * _weight / 100;
      }
      public static void ClearAll()
      {
        _instances.Clear();
      }
    }
}





// Create a Parcel class. It should contain a constructor, and getters and setters for each property. All properties should be set to private. You should be able to create a new parcel and specify the dimensions and weight in the arguments.
//
// Create a website where the user can submit a form with the dimensions and weight of a Parcel, and you can use the data in the form to instantiate a Parcel object and display its dimensions and weight.
//
// When you call a method called Volume() on a Parcel instance, it should return the product of the sides.
//
// When you call a CostToShip() method on your parcel, return a cost based on a formula you make up.
//
// Display the cost to ship and the volume of a Parcel with its dimensions in your site.
//
// Add validation: Make sure that the Parcel object is not created if any of the form fields are blank. Display an error message instead. Also remember to make sure that your user can only enter numbers into the form.
