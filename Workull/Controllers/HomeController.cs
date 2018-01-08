using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public string Create(Person person)
        {
            db.Persons.Add(person);
            db.SaveChanges();
            return "OK";
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Person deletedPerson =  db.Persons.ToList().First(p => p.Id == id);
            Console.WriteLine("hello");
            if (deletedPerson == null)
            {
                throw new HttpException(404, "Person not found");
            }
            return View(deletedPerson);
        }
        [HttpPost]
        public ActionResult Delete (Person person)
        {
            Person deletedPerson = db.Persons.First(p => p.Id == person.Id);
            db.Persons.Remove(deletedPerson);
            db.SaveChanges();
            return Redirect("~/Home/Index");
        }

    }
}
