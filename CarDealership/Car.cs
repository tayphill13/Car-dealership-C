using System;

namespace Dealership.Models
{
  public class Car
  {
      private string _makeModel;
      public string MakeModel
      {
        get
        {
          return "That's the Big secret. You'll have to visit Lonney's to find out about our specials!";
        }
        set 
        {
          _makeModel = value;
        }
      }
      private int _price;
      private int _miles;

      public static string MakeSound(string sound)
      {
        return "Our cars sound like " + sound;
      }
      public Car(string makeModel, int price, int miles)
      {
        _makeModel = makeModel;
        _price = price;
        _miles = miles;
      }

      public string GetMakeModel()
      {
        return _makeModel;
      }
      public int GetPrice()
      {
        return _price;
      }
      public void SetPrice(int newPrice)
      {
        _price = newPrice;
      }
      public int GetMiles()
      {
        return _miles;
      }
      public bool WorthBuying(int maxPrice)
      {
        return (_price < maxPrice);
      }
  }
}
