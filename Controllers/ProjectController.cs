using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using RegCodeFirst.Models;

namespace RegCodeFirst.Controllers
{
    public class ProjectController : Controller
    {
        DatabaseContext _context;
        public  ProjectController()
        {
            _context = new DatabaseContext();
        }
        [HttpGet]
        public ActionResult CityList(City city)
        {
            var a = _context.Cities.ToList();
            return View(a);
        }

        [HttpGet]
        public ActionResult CreateCity(City city)
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCity(City city,FormCollection formCollection)
        {
           var a = _context.Cities.Add(city);
            _context.SaveChanges();
            return View(a);
        }
        // GET: Project
        public ActionResult Index(Registration reg)
        {
            var a = _context.Registrations.ToList();
            return View(a);
        }

        // GET: Project/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Project/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Project/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
