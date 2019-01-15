using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyeccion.Models
{
    public interface IRepositoryProductos
    {
        List<Producto> GetProductos();
    }
}
