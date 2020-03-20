using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Salon.Controllers
{
    public class StylistsController : Controller {

      private readonly SalonContext _db;

    public StylistsController(SalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
    
    }

    public ActionResult Create()
    {
   
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
    
    }

    public ActionResult Details(int id)
    {
   
    }

    public ActionResult Edit(int id)
    {
    
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
 
    }

    public ActionResult Delete(int id)
    {
    
    }

    [HttpPost]
    public ActionResult DeleteConfirmed(int id)
    {
   
    }
    }
}