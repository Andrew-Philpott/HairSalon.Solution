using System;
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

    public ActionResult Search(string name)
    {
      List<Client> model = _db.Clients.Where(client => client.Name == name).ToList();
      return View(model);
    }

    public ActionResult Details(Guid id)
    {
      Client thisClient = _db.Clients
        .FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }
    public ActionResult Delete(Guid id)
    {
      Client thisClient = _db.Clients
       .FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(Guid id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      _db.Clients.Remove(thisClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}