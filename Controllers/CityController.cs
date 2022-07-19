using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using RegCodeFirst.Models;

namespace RegCodeFirst.Controllers
{
    public class CityController : Controller
    {
        DatabaseContext _context;
        public CityController()
        {
            _context = new DatabaseContext();
        }
        // GET: State
        public ActionResult IndexCity()
        {
            var a = _context.Cities.ToList();
            var b = _context.States.ToList();
            return View(a);
        }


        // GET: State/Create
        public ActionResult CreateCity()
        {
            var a = _context.States.ToList();
            City ct = new City();
            ct.GetStates = a;

            return View(ct);
        }

        // POST: State/Create
        [HttpPost]
        public ActionResult CreateCity(City city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
            return RedirectToAction("IndexCity");

        }

        // GET: State/Edit/5
        public ActionResult EditCity(int id)
        {
            var a = _context.Cities.Where(X => X.CityId == id).FirstOrDefault();
            var b = _context.States.ToList();
            City ct = new City();
            ct = a;
            ct.GetStates = b;
            return View(ct);
        }

        // POST: State/Edit/5
        [HttpPost]
        public ActionResult EditCity(City city)
        {
            var a = _context.Cities.Find(city.CityId);
            a.CityName = city.CityName;
            a.CityStateId = city.CityStateId;
            _context.SaveChanges();

            return RedirectToAction("IndexCity");

        }

        // GET: State/Delete/5
        public ActionResult DeleteCity(int id)
        {
            var a = _context.Cities.Where(X => X.CityId == id).FirstOrDefault();
            a.State = _context.States.Where(Y => Y.StateId == a.CityStateId).FirstOrDefault();

            return View(a);
        }

        // POST: State/Delete/5
        [HttpPost]
        public ActionResult DeleteCity(int id, FormCollection collection)
        {
            var a = _context.Cities.Find(id);
            _context.Cities.Remove(a);
            _context.SaveChanges();
            return RedirectToAction("IndexCity");

        }
    }
}
