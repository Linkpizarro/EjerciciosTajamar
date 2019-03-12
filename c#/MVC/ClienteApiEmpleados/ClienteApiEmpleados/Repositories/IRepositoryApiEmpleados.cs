using ClienteApiEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteApiEmpleados.Repositories
{
    public interface IRepositoryApiEmpleados
    {
        Task<List<Empleado>> GetEmpleados();

        Task<Empleado> BuscarEmpleado(int idempleado);
        Task<List<Empleado>> GetEmpleadosSalario(int salario);
    }
}
