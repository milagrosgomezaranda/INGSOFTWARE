using ControlDeCalidad.AccesoADatos;
using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Dominio.Interfaces;
using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class PresentadorPrincipal
    {
        private VPrincipal vPrincipal;
        private IRepositorioOrdenProduccion<OrdenProduccion> _repositorioOrdenProduccion;
        private IVista _vista;

        public PresentadorPrincipal(IVista vista, IRepositorioOrdenProduccion<OrdenProduccion> repositorioOrdenProduccion)
        {
            _vista = vista;
            _repositorioOrdenProduccion = repositorioOrdenProduccion;
        }

        internal bool TieneOrdenACargo()
        {
            return _repositorioOrdenProduccion.TieneLineaIniciada();
        }
    }
}
