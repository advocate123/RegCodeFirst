using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using RegCodeFirst.Models;

namespace RegCodeFirst.Controllers
{
    public class StateController : Controller
    {
        DatabaseContext _context;
        public StateController()
        {
            _context = new DatabaseContext();
        }
        // GET: State
        public ActionResult IndexState()
        {
            var a = _context.States.ToList();
            var b = _context.Countries.ToList();
            
           
            return View(a);
        }

       
        // GET: State/Create
        public ActionResult CreateState()
        {
            var a = _context.Countries.ToList();
            State st = new State();
            st.GetCountries = a;

            return View(st);
        }

        // POST: State/Create
        [HttpPost]
        public ActionResult CreateState(State state)
        {
            _context.States.Add(state);
            _context.SaveChanges();
                return RedirectToAction("IndexState");
            
        }

        // GET: State/Edit/5
        public ActionResult EditState(int id)
        {
            var a = _context.States.Where(X => X.StateId == id).FirstOrDefault();
            var b = _context.Countries.ToList();
            State st = new State();
            st = a;
           st.GetCountries = b;
            return View(st);
        }

        // POST: State/Edit/5
        [HttpPost]
        public ActionResult EditState(State st)
        {
            var a = _context.States.Find(st.StateId);
            a.StateName = st.StateName;
            a.StateCntId = st.StateCntId;
            _context.SaveChanges();
            
                return RedirectToAction("IndexState");
            
        }

        // GET: State/Delete/5
        public ActionResult DeleteState(int id)
        {
            var a = _context.States.Where(X => X.StateId == id).FirstOrDefault();
            a.Country= _context.Countries.Where(Y => Y.CountryId == a.StateCntId).FirstOrDefault();

            return View(a);
        }

        // POST: State/Delete/5
        [HttpPost]
        public ActionResult DeleteState(int id, FormCollection collection)
        {
            var a = _context.States.Find(id);
            _context.States.Remove(a);
            _context.SaveChanges();
                return RedirectToAction("IndexState");
            
        }
    }
}
