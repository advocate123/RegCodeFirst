using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using RegCodeFirst.Models;

namespace RegCodeFirst.Controllers
{
    public class CountryController : Controller
    {
        DatabaseContext _context;
        public CountryController()
        {
            _context = new DatabaseContext();
        }
        // GET: Country
        public ActionResult IndexCountry()
        {
            var a = _context.Countries.ToList();
            return View(a);
        }

      
        // GET: Country/Create
        public ActionResult CreateCountry()
        {
            return View();
        }

        // POST: Country/Create
        [HttpPost]
        public ActionResult CreateCountry(Country cnt)
        {
            _context.Countries.Add(cnt);
            _context.SaveChanges();
                return RedirectToAction("IndexCountry");
            
        }

        // GET: Country/Edit/5
        public ActionResult EditCountry(int id)
        {
            var a = _context.Countries.Where(X => X.CountryId == id).FirstOrDefault();
            return View(a);
        }

        // POST: Country/Edit/5
        [HttpPost]
        public ActionResult EditCountry(Country cnt)
        {
          var a =  _context.Countries.Find(cnt.CountryId);
            a.CountryId = cnt.CountryId;
            a.CountryName = cnt.CountryName;
            _context.SaveChanges();
                return RedirectToAction("IndexCountry");
          
        }

        // GET: Country/Delete/5
        public ActionResult DeleteCountry(int id)
        {
            var a = _context.Countries.Where(X => X.CountryId == id).FirstOrDefault();
            return View(a);
        }

        // POST: Country/Delete/5
        [HttpPost]
        public ActionResult DeleteCountry(int id, FormCollection formCollection)
        {
           var a = _context.Countries.Find(id);
            _context.Countries.Remove(a);
            _context.SaveChanges();
                return RedirectToAction("IndexCountry");
           
        }
    }
}
