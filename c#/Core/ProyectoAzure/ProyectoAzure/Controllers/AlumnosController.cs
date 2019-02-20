using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoAzure.Models;
using ProyectoAzure.Repositories;

namespace ProyectoAzure.Controllers
{
    public class AlumnosController : Controller
    {
        IRepositoryXml repo;

        public AlumnosController(IRepositoryXml repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.repo.GetAlumnos());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Alumno alumno)
        {
            this.repo.InsertarAlumno(alumno.IdAlumno, alumno.Nombre
                , alumno.Apellidos, alumno.Nota);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int idalumno)
        {
            Alumno alumno = this.repo.BuscarAlumno(idalumno);
            return View(alumno);
        }

        [HttpPost]
        public IActionResult Edit(Alumno alumno)
        {
            this.repo.ModificarAlumno(alumno.IdAlumno, alumno.Nombre
                , alumno.Apellidos, alumno.Nota);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int idalumno)
        {
            this.repo.EliminarAlumno(idalumno);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int idalumno)
        {
            Alumno alumno = this.repo.BuscarAlumno(idalumno);
            return View(alumno);
        }
    }
}