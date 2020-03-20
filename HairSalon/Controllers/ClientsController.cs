using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {

    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
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
    // public ActionResult Create(Client client)
    // {

    // }

    // public ActionResult Details(int id)
    // {

    // }

    // public ActionResult Edit(int id)
    // {

    // }

    // [HttpPost]
    // public ActionResult Edit(Client client)
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