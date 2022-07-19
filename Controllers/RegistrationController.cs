using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using RegCodeFirst.Models;

namespace RegCodeFirst.Controllers
{
    public class RegistrationController : Controller
    {
        DatabaseContext _context;
        public RegistrationController()
        {
            _context = new DatabaseContext();
        }

        // GET: Registration
        public ActionResult Index()
        {
            var a = _context.Registrations.ToList();
            var b = _context.Cities.ToList();

            return View(a);
        }

        // GET: Registration/Details/5
        public ActionResult Details(int id)
        {
            var a = _context.Registrations.Where(X => X.RegId == id).FirstOrDefault();
            a.City = _context.Cities.Where(Y => Y.CityId == a.RegCityId).FirstOrDefault();
            return View(a);
        }

        // GET: Registration/Create
        public ActionResult Create()
        {
            var a = _context.Cities.ToList();
            Registration rg = new Registration();
            rg.GetCities = a;
            return View(rg);
        }

        // POST: Registration/Create
        [HttpPost]
        public ActionResult Create(Registration rg)
        {
            _context.Registrations.Add(rg);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET: Registration/Edit/5
        public ActionResult Edit(int id)
        {
            var a = _context.Registrations.Where(X => X.RegId == id).FirstOrDefault();
            var b = _context.Cities.ToList();
            Registration rg = new Registration();
            rg = a;
            rg.GetCities = b;

            return View(rg);
        }

        // POST: Registration/Edit/5
        [HttpPost]
        public ActionResult Edit(Registration rg)
        {
            var a = _context.Registrations.Find(rg.RegId);
            a.Name = rg.Name;
            a.Address = rg.Address;
            a.EMail = rg.EMail;
            a.RegCityId = rg.RegCityId;
            _context.SaveChanges();

            return RedirectToAction("Index");

        }

        // GET: Registration/Delete/5
        public ActionResult Delete(int id)
        {
            City ct = new City();
            var a = _context.Registrations.Where(X => X.RegId == id).FirstOrDefault();
            a.City = _context.Cities.Where(Y => Y.CityId == a.RegCityId).FirstOrDefault(); ;
           

            return View(a);
        }

        // POST: Registration/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,FormCollection form)
        {
            var a = _context.Registrations.Find(id);

            _context.Registrations.Remove(a);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
