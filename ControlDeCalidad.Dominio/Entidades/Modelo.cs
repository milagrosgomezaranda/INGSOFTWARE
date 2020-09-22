using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class Modelo
    {
        public int NumeroTalle { get; set; }
        public string Descripcion { get; set; }
        public Color Color { get; set; }

        public Modelo(int NumeroTalle, string Descripcion)
        {
            this.NumeroTalle = NumeroTalle;
            this.Descripcion = Descripcion;
        }

        public override string ToString()
        {
            return NumeroTalle + " - " + Descripcion;
        }
    }
}
