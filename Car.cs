using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;
  private string _color;
  private int _year;

  public void SetMakeModel(string newMakeModel)
  {
    _makeModel = newMakeModel;
  }
  public string GetMakeModel()
  {
    return _makeModel;
  }

  public void SetPrice(int newPrice)
  {
    _price = newPrice;
  }
  public int GetPrice()
  {
    return _price;
  }

  public void SetMiles(int newMiles)
  {
    _miles = newMiles;
  }
  public int GetMiles()
  {
    return _miles;
  }

  public void SetColor(string newColor)
  {
    _color = newColor;
  }
  public string GetColor()
  {
    return _color;
  }

  public void SetYear(int newYear)
  {
    _year = newYear;
  }
  public int GetYear()
  {
    return _year;
  }
  
  public Car(string carMakeModel, int carPrice, int carMiles, int carYear = 2010, string carColor = "black")
  {
    _makeModel = carMakeModel;
    _price = carPrice;
    _miles = carMiles;
    _color = carColor;
    _year = carYear;
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car("Porsche", 10000, 1000, 2016, "yellow");
    Car ford = new Car("Ford Raptor", 60000, 2500);
    Car bmw = new Car("BMW M5", 110000, 25000);
    Car mercedes = new Car("Mercedes AMG", 120000, 3200);
    Car gio = new Car("Gio Storm", 2000, 89, 1999);

    List<Car> Cars = new List<Car>() { porsche, ford, bmw, mercedes, gio };

    foreach (Car automobile in Cars)
    {
      Console.WriteLine(automobile.GetMakeModel());
      Console.WriteLine(automobile.GetColor());
    }
    Console.WriteLine("Enter max price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.GetPrice() <= maxPrice)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
    foreach (Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetMakeModel());
      Console.WriteLine(automobile.GetColor());
    }
  }

}
