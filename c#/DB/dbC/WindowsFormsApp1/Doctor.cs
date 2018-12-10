using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Doctor
    {
        String _Doctor_no;
        String _Apellido;
        String _Especialidad;
        String _Hospital;
        String _Salario;

        public String Doctor_no { get => _Doctor_no; set => _Doctor_no = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Especialidad { get => _Especialidad; set => _Especialidad = value; }
        public string Hospital { get => _Hospital; set => _Hospital = value; }
        public string Salario { get => _Salario; set => _Salario = value; }
    }
}
