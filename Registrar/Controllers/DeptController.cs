using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System;
using Registrar.Models;

namespace Registrar.Controllers
{
    public class DeptController : Controller
    {
        private readonly RegistrarContext _db;
        public DeptController(RegistrarContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Dept> model = _db.Depts.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Dept dept)
        {
            _db.Depts.Add(dept);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisDept = _db.Depts.FirstOrDefault(dept => dept.DeptId == id);
            return View(thisDept);
        }
    }
}