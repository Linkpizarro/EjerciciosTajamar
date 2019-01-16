using InyeccionEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionEntity.Repositories
{
    public interface IRepositoryHospital
    {
        List<Hospital> GetHospitales();
    }
}
