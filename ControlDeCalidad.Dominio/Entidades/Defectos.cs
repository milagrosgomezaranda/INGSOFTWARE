using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class Defectos
    {
        public string Descripcion { get; set; }
        public Defectos(string defecto)
        {
            Descripcion = defecto;
        }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
