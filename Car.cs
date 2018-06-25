using System;
using System.Collections.Generic;

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car();
    porsche.MakeModel = "2014 Porsche 911";
    porsche.Price = 114991;
    porsche.Miles = 7864;

    Car ford = new Car();
    ford.MakeModel = "2017 Ford Raptor";
    ford.Price = 60000;
    ford.Miles = 2500;

    Car bmw = new Car();
    bmw.MakeModel = "2012 BMW M5";
    bmw.Price = 110000;
    bmw.Miles = 25000;

    Car mercedes = new Car();
    mercedes.MakeModel = "2013 Mercedes AMG";
    mercedes.Price = 120000;
    mercedes.Miles = 32000;

    Car gio = new Car();
    gio.MakeModel = "1992 Gio Storm";
    gio.Price = 4000;
    gio.Miles = 132000;

    List<Car> Cars = new List<Car>() { porsche, ford, bmw, mercedes, gio };

    foreach (Car automobile in Cars)
    {
      Console.WriteLine(automobile.MakeModel);
    }
    Console.WriteLine("Enter max price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.Price < maxPrice)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
    foreach (Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }
  }

}
