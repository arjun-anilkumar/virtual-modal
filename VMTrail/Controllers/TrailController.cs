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


        public ActionResult SecondList()
        {
            DataBaseOneEntities1 db = new DataBaseOneEntities1();
            //Author a = new Author();
            //book b = new book();
            //List<book> li = new List<book>;
            //return (li);
            ReqJoin r = new ReqJoin
            {
                books = db.books.ToList(),
                
            };

            return View(r);
        }
    }
}