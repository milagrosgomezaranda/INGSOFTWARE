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
    public class PresentadorOperacionACargoLinea
    {
        private IRepositorioOrdenProduccion<OrdenProduccion> _repositorioOrdenProduccion;
        private IVOperacionACargoLinea _vista;
        private OrdenProduccion _ordenProduccion;
        public PresentadorOperacionACargoLinea(IRepositorioOrdenProduccion<OrdenProduccion> repositorioOrdenProduccion, IVOperacionACargoLinea vista)
        {
            _repositorioOrdenProduccion = repositorioOrdenProduccion;
            _vista = vista;
            Iniciar();
        }

        private void Iniciar()
        {
            _ordenProduccion = _repositorioOrdenProduccion.GetOperacionACargo();
            _vista.DevolverOperacionACargo(_ordenProduccion);
        }

        internal void Pausar()
        {
            _ordenProduccion.EstadoOP = EstadoOP.Pausada;
            _ordenProduccion = _repositorioOrdenProduccion.Modificar(_ordenProduccion);
            _vista.DevolverOperacionACargo(_ordenProduccion);
        }

        internal void Continuar()
        {
            _ordenProduccion.EstadoOP = EstadoOP.EnProceso;
            _ordenProduccion = _repositorioOrdenProduccion.Modificar(_ordenProduccion);
            _vista.DevolverOperacionACargo(_ordenProduccion);
        }

        internal void Finalizar()
        {
            _ordenProduccion.EstadoOP = EstadoOP.Finalizada;
            _ordenProduccion = _repositorioOrdenProduccion.Modificar(_ordenProduccion);
            _vista.DevolverOperacionACargo(_ordenProduccion);
        }
    }
}
