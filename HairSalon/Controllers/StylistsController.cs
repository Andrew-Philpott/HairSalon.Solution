using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {

    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    // public ActionResult Index()
    // {

    // }

    // public ActionResult Create()
    // {

    // }

    // [HttpPost]
    // public ActionResult Create(Stylist stylist)
    // {

    // }

    // public ActionResult Details(int id)
    // {

    // }

    // public ActionResult Edit(int id)
    // {

    // }

    // [HttpPost]
    // public ActionResult Edit(Stylist stylist)
    // {

    // }

    // public ActionResult Delete(int id)
    // {

    // }

    // [HttpPost]
    // public ActionResult DeleteConfirmed(int id)
    // {

    // }
  }
}