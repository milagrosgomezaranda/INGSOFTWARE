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
    public class PresentadorIniciarOP
    {
        private IVistaIniciarOP _vista;
        private IRepositorioModelo<Modelo> _repositorioModelo;
        private IRepositorioColor<Color> _repositorioColor;
        private IRepositorioUsuario<Usuario> _repositorioUsuario;
        private IRepositorioOrdenProduccion<OrdenProduccion> _repositorioOrdenProduccion;
        private OrdenProduccion _ordenProduccion;
        public PresentadorIniciarOP(IVistaIniciarOP vista, IRepositorioModelo<Modelo> repositorioModelo,
            IRepositorioColor<Color> repositorioColor, IRepositorioUsuario<Usuario> repositorioUsuario,
            IRepositorioOrdenProduccion<OrdenProduccion> repositorioOrdenProduccion)
        {
            _vista = vista;
            _repositorioModelo = repositorioModelo;
            _repositorioColor = repositorioColor;
            _repositorioUsuario = repositorioUsuario;
            _repositorioOrdenProduccion = repositorioOrdenProduccion;
        }

        internal void Iniciar()
        {
            _vista.PoblarModelos(_repositorioModelo.GetTodos());
            _vista.PoblarColores(_repositorioColor.GetTodos());
            _vista.PoblarSupervisorCalidad(_repositorioUsuario.GetSupervisoresCalidad());
            _ordenProduccion = new OrdenProduccion();
        }

        internal bool Validar()
        {
            bool validar = true;
            if (_ordenProduccion.SupCalidad == null)
            {
                MessageBox.Show("No seleccionó un Supervisor de calidad", "Iniciar OP", MessageBoxButtons.OK,
                true ? MessageBoxIcon.Error : MessageBoxIcon.Information);
                validar = false;
            }
            if (_ordenProduccion.Modelo == null)
            {
                MessageBox.Show("No seleccionó un Modelo", "Iniciar OP", MessageBoxButtons.OK,
                true ? MessageBoxIcon.Error : MessageBoxIcon.Information);
            }
            else
            {
                if (_ordenProduccion.Modelo.Color == null)
                {
                    MessageBox.Show("No seleccionó un Color", "Iniciar OP", MessageBoxButtons.OK,
                    true ? MessageBoxIcon.Error : MessageBoxIcon.Information);
                }
            }            
            if (_ordenProduccion.Objetivo == null || _ordenProduccion.Objetivo.Cantidad == 0)
            {
                MessageBox.Show("No ingresó un Objetivo", "Iniciar OP", MessageBoxButtons.OK,
                true ? MessageBoxIcon.Error : MessageBoxIcon.Information);
            }
            return validar;
        }

        internal OrdenProduccion Finalizar()
        {
            _ordenProduccion.LineaTrabajo = new LineaTrabajo((SupLinea)Sesion.Instance.UsuarioLogueado);
            return _repositorioOrdenProduccion.Agregar(_ordenProduccion);
        }

        internal void SeleccionarModelo(Modelo selectedItem)
        {
            if (_ordenProduccion != null)
            {
                _ordenProduccion.Modelo = selectedItem;
            }
        }

        internal void SeleccionarColor(Color selectedItem)
        {
            if (_ordenProduccion != null)
            {
                _ordenProduccion.Modelo.Color = selectedItem;
            }
        }

        internal void IngresarObjetivo(int objetivo)
        {
            _ordenProduccion.Objetivo.Cantidad = objetivo;
        }

        internal void SeleccionarSC(SupCalidad supCalidad)
        {
            if (_ordenProduccion != null)
            {
                _ordenProduccion.AgregarSupervisorCalidad(supCalidad);
            }
        }
    }
}
