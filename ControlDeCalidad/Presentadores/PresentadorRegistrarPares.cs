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
    public class PresentadorRegistrarPares
    {
        private IRepositorioOrdenProduccion<OrdenProduccion> _repositorioOrdenProduccion;
        private IVRegistrarPares _vista;
        private OrdenProduccion _ordenProduccion;
        private IRepositorioDefectos<Defectos> _repositorioDefectos;
        public PresentadorRegistrarPares(IRepositorioOrdenProduccion<OrdenProduccion> repositorioOrdenProduccion, 
            IVRegistrarPares vista, IRepositorioDefectos<Defectos> repositorioDefectos)
        {
            _repositorioOrdenProduccion = repositorioOrdenProduccion;
            _vista = vista;
            _repositorioDefectos = repositorioDefectos;
        }

        internal void Iniciar()
        {
            _ordenProduccion = _repositorioOrdenProduccion.GetOperacionACargo();
            _vista.SetOrdenProduccion(_ordenProduccion);
            _vista.PoblarComboBox(_repositorioDefectos.GetTodos(),_repositorioDefectos.GetTodos());
        }

        internal void RegistrarParPrimera()
        {
            _ordenProduccion.AgregarParPrimera(new Par());
            _ordenProduccion = _repositorioOrdenProduccion.Modificar(_ordenProduccion);
            _vista.LimpiarVentana();
            MessageBox.Show("Se registro par de primera", "Registrar Pares", MessageBoxButtons.OK,
                    true ? MessageBoxIcon.Information : MessageBoxIcon.Information);
        }

        internal void RegistrarParSegunda()
        {
            _ordenProduccion.AgregarParSegunda(new Par());
            _ordenProduccion = _repositorioOrdenProduccion.Modificar(_ordenProduccion);
            _vista.LimpiarVentana();
            MessageBox.Show("Se registro par de Segunda", "Registrar Pares", MessageBoxButtons.OK,
                    true ? MessageBoxIcon.Information : MessageBoxIcon.Information);
        }

        internal void RegistrarReproceso(Defectos defectoIzquierdo, Defectos defectoDerecho)
        {
            _ordenProduccion.AgregarReproceso(new Par(new Unidad("Izquierdo", defectoIzquierdo), new Unidad("Derecho", defectoDerecho)));
            _ordenProduccion = _repositorioOrdenProduccion.Modificar(_ordenProduccion);
            _vista.LimpiarVentana();
            MessageBox.Show("Se registro Reproceso", "Registrar Pares", MessageBoxButtons.OK,
                    true ? MessageBoxIcon.Information : MessageBoxIcon.Information);
        }
    }
}
