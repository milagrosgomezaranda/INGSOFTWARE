using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Dominio.Interfaces;
using ControlDeCalidad.Presentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class PresentadorLogin
    {
        private IVistaLogin _vista;
        private IRepositorioUsuario<Usuario> _repositorio;
        public PresentadorLogin(IVistaLogin vista, IRepositorioUsuario<Usuario> repositorio)
        {
            _vista = vista;
            _repositorio = repositorio;
        }
        internal bool Login(string usuario, string contraseña)
        {
            return _repositorio.Login(usuario,contraseña);
        }
    }
}
