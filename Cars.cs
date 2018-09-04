using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;
  private string _carNote;

  public Car(string carModel, int carMiles, string carNote, int carPrice = 2000)
  {
    _makeModel = carModel;
    _price = carPrice;
    _miles = carMiles;
    _carNote = carNote;
  }

  public void SetMakeModel(string newMakeModel)
  {
    _makeModel = newMakeModel;
  }
  public string GetMakeModel()
  {
    return _makeModel;
  }

  public void SetPrice(int newCarPrice)
  {
    _price = newCarPrice;
  }
  public int GetPrice()
  {
    return _price;
  }

  public void SetMiles(int newCarMiles)
  {
    _miles = newCarMiles;
  }
  public int GetMiles()
  {
    return _miles;
  }

  public void SetCarNote(string newCarNote)
  {
    _carNote = newCarNote;
  }
  public string GetCarNote()
  {
    return _carNote;
  }

}

public class Program
{
  public static void Main()
  {
    // Car porsche = new Car();
    // porsche.MakeModel = "2014 Porsche 911";
    // porsche.Price = 114991;
    // porsche.Miles = 7864;
    //
    // Car ford = new Car();
    // ford.MakeModel = "2011 Ford F450";
    // ford.Price = 55995;
    // ford.Miles = 14241;
    //
    // Car lexus = new Car();
    // lexus.MakeModel = "2013 Lexus RX 350";
    // lexus.Price = 44700;
    // lexus.Miles = 20000;
    //
    // Car mercedes = new Car();
    // mercedes.MakeModel = "Mercedes Benz CLS550";
    // mercedes.Price = 39900;
    // mercedes.Miles = 37979;

    // Car firstCar = new Car("2014 Porsche 911", 7864);
    // Car secondCar = new Car("2011 Ford F450", 14241);
    // Car thirdCar = new Car("2013 Lexus RX 350", 20000);
    // Car fourthCar = new Car("Mercedes Benz CLS550", 37979);

    Car firstCar = new Car("2014 Porsche 911", 114991, "this car is red", 7864);
    // firstCar.SetMakeModel("2014 Porsche 911");
    // firstCar.SetPrice(114991);
    // firstCar.SetMiles(7864);

    Car secondCar = new Car("2011 Ford F450", 55995, "this car smells", 14241);
    // secondCar.SetMakeModel("2011 Ford F450");
    // secondCar.SetPrice(55995);
    // secondCar.SetMiles(14241);

    List<Car> Cars = new List<Car>() {firstCar, secondCar};

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.GetPrice() < maxPrice && automobile.GetMiles() < maxMiles)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetMakeModel());
      Console.WriteLine(automobile.GetCarNote());
    }


  }
}
