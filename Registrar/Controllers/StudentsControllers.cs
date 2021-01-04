using Microsoft.AspNetCore.Mvc;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Registrar.Controllers
{
    public class StudentsController : Controller
    {
        private readonly RegistrarContext _db; //creates secure db?

        public StudentsController(RegistrarContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Students.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
            return View(thisStudent);
        }

        public ActionResult Edit(int id)
        {
            var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
            return View(thisStudent);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            _db.Entry(student).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}