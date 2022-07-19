using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using RegCodeFirst.Models;

namespace RegCodeFirst.Controllers
{
    public class MasterController : Controller
    {
        // GET: Master
        public ActionResult Index()
        {

            return View();
        }
    }
}