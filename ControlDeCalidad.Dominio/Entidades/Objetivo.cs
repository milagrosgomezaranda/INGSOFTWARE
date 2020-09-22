using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class Objetivo
    {
        public int Cantidad { get; set; }
        public override string ToString()
        {
            return Cantidad.ToString();
        }
    }
}
