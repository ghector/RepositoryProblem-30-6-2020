using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using RepositoryProblem.Core.Domain;
using RepositoryProblem.Persistance;
using RepositoryProblem.Persistance.Repositories;

namespace RepositoryProblem.Controllers
{
    public class StudentController : Controller
    {
        UnitOfWork UnitOfWork = new UnitOfWork(new ApplicationDbContext());

       

        // GET: Student
        public ActionResult Index()
        {
            



            return View(UnitOfWork.Students.GetTopStudents(5));
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = UnitOfWork.Students.Get(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentId,Age,Name,Score")] Student student)
        {
            if (ModelState.IsValid)
            {
                UnitOfWork.Students.Add(student);
                UnitOfWork.Complete();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = UnitOfWork.Students.Get(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,Age,Name,Score")] Student student)
        {
            if (ModelState.IsValid)
            {
                UnitOfWork.Students.Edit(student);
                UnitOfWork.Complete();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = UnitOfWork.Students.Get(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = UnitOfWork.Students.Get(id);
            UnitOfWork.Students.Remove(student);
            UnitOfWork.Complete();
            return RedirectToAction("Index");
        }

        
    }
}
