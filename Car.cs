using System;
using System.Collections.Generic;

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public string Color;
  public int Year;

  public Car(string carMakeModel, int carPrice, int carMiles, string carColor = "black", int carYear = 2010)
  {
    MakeModel = carMakeModel;
    Price = carPrice;
    Miles = carMiles;
    Color = carColor;
    Year = carYear;
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car("Porsche 911", 114991, 7864 );
    Car ford = new Car("Ford Raptor", 60000, 2500);
    Car bmw = new Car("BMW M5", 110000, 25000);
    Car mercedes = new Car("Mercedes AMG", 120000, 32000);
    Car gio = new Car("Gio Storm", 2000, 89, "white", 1999);

    List<Car> Cars = new List<Car>() { porsche, ford, bmw, mercedes, gio };

    foreach (Car automobile in Cars)
    {
      Console.WriteLine(automobile.MakeModel);
      Console.WriteLine(automobile.Color);
    }
    Console.WriteLine("Enter max price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.Price <= maxPrice)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
    foreach (Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
      Console.WriteLine(automobile.Color);
    }
  }

}
