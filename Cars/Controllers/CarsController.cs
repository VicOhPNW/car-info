using Microsoft.AspNetCore.Mvc;
using Cars.Models;
using System.Collections.Generic;

namespace Cars.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List <Car> allCars = Car.GetInstances();
      return View(allCars);
    }

    [HttpGet("/cars/{id}")]
    public ActionResult Details(int id)
    {
      Car car = Car.Find(id);
      return View(car);
    }

    [HttpGet("/cars/add")]
    public ActionResult AddCar()
    {
      return View();
    }

    [HttpPost("/cars/add")]
    public ActionResult Add()
    {
      string makeModel = Request.Form["makeModel"];
      int price = int.Parse(Request.Form["price"]);
      int miles = int.Parse(Request.Form["miles"]);
      string carNote = Request.Form["carNote"];
      Car newCar = new Car(makeModel, price, miles, carNote);
      // newCar.AddCar();
      List <Car> allCars = Car.GetInstances();

      return View("Index", allCars);
    }

    [HttpPost("/cars/delete")]
    public ActionResult DeleteAll()
    {
      Car.DeleteAll();
      return View();
    }
  }
}
