using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class SupCalidad : Usuario
    {
        public SupCalidad(int legajo,int documento,string nombre,string apellido,string usuario, string contraseña) : base(usuario, contraseña)
        {
            Legajo = legajo;
            Nombre = nombre;
            Documento = documento;
            Apellido = apellido;
        }

        public int Legajo { get; set; }
        public string Nombre{ get; set; }
        public int Documento { get; set; }
        public String Apellido { get; set; }
        public override string ToString()
        {
            return Legajo + " - " + NombreUsuario;
        }
    }
}
