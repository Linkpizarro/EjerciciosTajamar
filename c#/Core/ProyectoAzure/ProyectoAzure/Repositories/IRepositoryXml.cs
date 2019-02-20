using ProyectoAzure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAzure.Repositories
{
    public interface IRepositoryXml
    {
        List<Joyeria> GetJoyerias();

        List<Alumno> GetAlumnos();

        Alumno BuscarAlumno(int idalumno);

        void EliminarAlumno(int idalumno);
        void InsertarAlumno(int idalumno, String nombre, String apellidos
            , int nota);
        void ModificarAlumno(int idalumno, String nombre, String apellidos
            , int nota);
    }
}
