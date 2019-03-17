using ClienteApiSeguridadCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteApiSeguridadCore.Repositories
{
    public interface IRepositoryApiEmpleados
    {
        Task<String> GetToken(String usuario, String password);
        //METODO LIBRE
        Task<Empleado> BuscarEmpleado(int empno);
        //METODOS CON SEGURIDAD
        Task<List<Empleado>> GetEmpleados(String token);

        Task<List<Empleado>> GetEmpleadosSubordinados(String token);

        Task<Empleado> PerfilEmpleado(String token);
    }
}
