using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class LineaTrabajo
    {
        public int IdLinea { get; set; }
        public string nombre { get; set; }
        public SupLinea SupLinea { get; set; }
        public LineaTrabajo(SupLinea supLinea)
        {
            IdLinea++;
            SupLinea = supLinea;
        }

        public override string ToString()
        {
            return IdLinea.ToString();
        }
    }
}
