using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VMTrail.Models;

namespace VMTrail.Controllers
{
    public class TrailController : Controller
    {
        // GET: Trail
        public ActionResult Index()
        {

            DataBaseOneEntities db = new DataBaseOneEntities();
            Req r = new Req
            {
               Employees = db.Employeees.ToList(),
                authusers = db.authusers.ToList()
            };
            return View(r);
        }

        public ActionResult List()
        {
       

            DataBaseOneEntities db = new DataBaseOneEntities();
            Req r = new Req
            {
                Employees = db.Employeees.ToList(),
                authusers = db.authusers.ToList()
            };
            return View(r);
        }
    }
}