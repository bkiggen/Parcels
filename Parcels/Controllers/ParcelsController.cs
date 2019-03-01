using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Box> allBoxes = Box.GetAll();
      return View(allBoxes);
    }
    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/parcels")]
    public ActionResult Create(string length, string width, string height, string weight)
    {
      Box myBox = new Box(length, width, height, weight);
      return RedirectToAction("Index");
    }
  }
}
