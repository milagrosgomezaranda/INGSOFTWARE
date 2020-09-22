using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class Par
    {
        public string Description { get; set; }
        private Unidad PieIzquierdo { get; set; }
        private Unidad PieDerecho { get; set; }
        public Par()
        {

        }
        public Par(Unidad pieIzquierdo,Unidad pieDerecho)
        {
            PieIzquierdo = pieIzquierdo;
            PieDerecho = pieDerecho;
        }
    }
}
