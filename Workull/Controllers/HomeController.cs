using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Workull.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        workullEntities db = new workullEntities();
        public ActionResult Index()
        {
            var list = db.Persons.ToList();
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Person person)
        {
            db.Persons.Add(person);
            db.SaveChanges();
            return Redirect("~/Home/Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Person deletedPerson =  db.Persons.ToList().FirstOrDefault(p => p.Id == id);
           
            if (deletedPerson == null)
            {
                return HttpNotFound();
            }
            return View(deletedPerson);
        }
        [HttpPost]
        public ActionResult Delete (Person person)
        {
            Person deletedPerson = db.Persons.FirstOrDefault(p => p.Id == person.Id);
            if (deletedPerson == null)
            {
                return HttpNotFound();
            }
            db.Persons.Remove(deletedPerson);
            db.SaveChanges();
            return Redirect("~/Home/Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Person person = db.Persons.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }
        [HttpPost]
        public ActionResult Edit(Person person)
        {
            db.Entry(person).State = EntityState.Modified;
            db.SaveChanges();
            return Redirect("~/Home/Index");
        }
        public ActionResult Details(int id)
        {
            Person person = db.Persons.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

    }
}
