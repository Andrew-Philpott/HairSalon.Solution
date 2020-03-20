using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

    public ActionResult Index()
    {
      ViewBag.HasStylists = _db.Stylists.Any();
      List<Client> model = _db.Clients.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

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