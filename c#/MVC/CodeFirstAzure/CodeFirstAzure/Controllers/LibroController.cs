using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeFirstAzure.Data;
using CodeFirstAzure.Models;

namespace CodeFirstAzure.Controllers
{
    public class LibroController : Controller
    {
        private LibraryContext db = new LibraryContext();

        // GET: Libro
        public ActionResult Index()
        {
            var libros = db.Libros.Include(l => l.Genero);
            return View(libros.ToList());
        }

        // GET: Libro/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libro libro = db.Libros.Find(id);
            if (libro == null)
            {
                return HttpNotFound();
            }
            return View(libro);
        }

        // GET: Libro/Create
        public ActionResult Create()
        {
            ViewBag.IdGenero = new SelectList(db.Generos, "IdGenero", "Nombre");
            return View();
        }

        // POST: Libro/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdLibro,Nombre,Autor,Sinopsis,IdGenero")] Libro libro)
        {
            if (ModelState.IsValid)
            {
                db.Libros.Add(libro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdGenero = new SelectList(db.Generos, "IdGenero", "Nombre", libro.IdGenero);
            return View(libro);
        }

        // GET: Libro/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libro libro = db.Libros.Find(id);
            if (libro == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdGenero = new SelectList(db.Generos, "IdGenero", "Nombre", libro.IdGenero);
            return View(libro);
        }

        // POST: Libro/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdLibro,Nombre,Autor,Sinopsis,IdGenero")] Libro libro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(libro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdGenero = new SelectList(db.Generos, "IdGenero", "Nombre", libro.IdGenero);
            return View(libro);
        }

        // GET: Libro/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libro libro = db.Libros.Find(id);
            if (libro == null)
            {
                return HttpNotFound();
            }
            return View(libro);
        }

        // POST: Libro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Libro libro = db.Libros.Find(id);
            db.Libros.Remove(libro);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
