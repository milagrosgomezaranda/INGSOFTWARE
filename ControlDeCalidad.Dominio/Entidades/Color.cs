using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class Color
    {
        public string Tipo { get; set; }
        public Color(string tipo)
        {
            Tipo = tipo;
        }
        public override string ToString()
        {
            return Tipo;
        }
    }
}
