using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Dominio.Interfaces;
using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Presentacion.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class PresentadorInformePrimera
    {
        private IVInformePrimera _vista;
        private IRepositorioOrdenProduccion<OrdenProduccion> _repositorioOrdenProduccion;
        private OrdenProduccion _ordenProduccion;

        public PresentadorInformePrimera(VInformePrimera vista, IRepositorioOrdenProduccion<OrdenProduccion> repositorioOrdenProduccion)
        {
            _vista = vista;
            _repositorioOrdenProduccion = repositorioOrdenProduccion;
        }

        internal void Iniciar()
        {
            _ordenProduccion = _repositorioOrdenProduccion.GetOperacionACargo();
            _vista.SetInformePrimera(_ordenProduccion);
        }
    }
}
