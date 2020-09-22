using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Dominio.Interfaces;
using ControlDeCalidad.Presentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeCalidad.Presentacion.Presentadores
{
    public class PresentadorSeleccionarOP
    {
        public IRepositorioOrdenProduccion<OrdenProduccion> _repositorioOrdenProduccion;
        public IVSeleccionarOP _vista;
        public PresentadorSeleccionarOP(IRepositorioOrdenProduccion<OrdenProduccion> repositorioOrdenProduccion,IVSeleccionarOP vista)
        {
            _repositorioOrdenProduccion = repositorioOrdenProduccion;
            _vista = vista;
        }

        internal void GetOrdenesProduccion()
        {
            _vista.ActualizarTablaOrdenes(_repositorioOrdenProduccion.GetOrdenProduccionParaSupCalidad());
        }

        internal void SeleccionarOrdenProduccion(OrdenProduccion ordenProduccion)
        {
            if (!_repositorioOrdenProduccion.TieneLineaIniciada())
            {
                ordenProduccion.SupCalidad = (SupCalidad)Sesion.Instance.UsuarioLogueado;
                _vista.ActualizarTablaOrdenes(_repositorioOrdenProduccion.GetOrdenProduccionParaSupCalidad());
            }
            else
            {
                MessageBox.Show("Ya tiene una Orden de Producción Iniciada","Seleccionar OP", MessageBoxButtons.OK,true ? MessageBoxIcon.Error : MessageBoxIcon.Information);
            }
            
        }
    }
}
