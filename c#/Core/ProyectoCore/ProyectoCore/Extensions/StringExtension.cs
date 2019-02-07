using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCore.Extensions
{
    public static class StringExtension
    {
        public static int GetNumWords(this String text)
        {
            return text.Split(' ').Count();
        }
    }
}
