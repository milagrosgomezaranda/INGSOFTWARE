using ControlDeCalidad.AccesoADatos;
using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Presentacion.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class PresentadorOperacionACargoCalidad
    {
        private RepositorioOrdenProduccion _repositorioOrdenProduccion;
        private IVOperacionACargoCalidad _vista;
        private OrdenProduccion _ordenProduccion;

        public PresentadorOperacionACargoCalidad(RepositorioOrdenProduccion repositorioOrdenProduccion, IVOperacionACargoCalidad vista)
        {
            _vista = vista;
            _repositorioOrdenProduccion = repositorioOrdenProduccion;
        }

        internal void Iniciar()
        {
            _ordenProduccion = _repositorioOrdenProduccion.GetOperacionACargo();
            _vista.DevolverOperacionACargo(_ordenProduccion);
        }

        internal bool AbandonarOP()
        {
            _ordenProduccion.SupCalidad = null;
            _repositorioOrdenProduccion.Modificar(_ordenProduccion);
            return _repositorioOrdenProduccion.TieneLineaIniciada();
        }
    }
}
