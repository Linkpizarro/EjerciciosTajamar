using LogicaEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmpleados.Logic
{
    [ServiceContract]
    public interface IServiceEmpleados
    {
        [OperationContract]
        List<String> GetOficios();
        [OperationContract]
        List<Empleado> GetEmpleadosOficio(String oficio);
    }
}
