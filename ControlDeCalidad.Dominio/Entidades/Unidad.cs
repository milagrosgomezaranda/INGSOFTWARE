using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class Unidad
    {
        public string Pie { get; set; }
        public Defectos Defecto { get; set; }
        public Unidad(string pie, Defectos defecto)
        {
            Pie = pie;
            Defecto = defecto;
        }
    }
}
