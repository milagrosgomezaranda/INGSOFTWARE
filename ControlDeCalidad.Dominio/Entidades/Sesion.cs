using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Dominio.Entidades
{
    public class Sesion
    {
        private readonly static Sesion _instance = new Sesion();
        public Usuario UsuarioLogueado { get; set; }
        private Sesion()
        {

        }
        public static Sesion Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
