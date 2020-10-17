using ControlDeCalidad.AccesoADatos;
using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Dominio.Interfaces;
using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeCalidad.Presentacion.Vistas
{
    public partial class VSeleccionarOP : Form,IVSeleccionarOP
    {
        private PresentadorSeleccionarOP _presentador;
        public VSeleccionarOP()
        {
            InitializeComponent();
            _presentador = new PresentadorSeleccionarOP(RepositorioOrdenProduccion.Instance,this);
            _presentador.GetOrdenesProduccion();
        }

        public void ActualizarTablaOrdenes(List<OrdenProduccion> list)
        {
            dgvOrdenProduccion.DataSource = list;
        }

        private void dgvOrdenProduccion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrdenProduccion.SelectedRows.Count > 0)
            {
                int index = dgvOrdenProduccion.SelectedRows[0].Index;
                OrdenProduccion ordenProduccion = (OrdenProduccion)dgvOrdenProduccion.SelectedRows[0].DataBoundItem;
                VSeleccionarOPEmergente vista = new VSeleccionarOPEmergente();
                vista.SetOrdenProduccion(ordenProduccion);
                vista.AceptarClicked += IniciarLinea;
                vista.ShowDialog();
            }
        }

        public void IniciarLinea(object sender,OrdenProduccion ordenProduccion)
        {
            _presentador.SeleccionarOrdenProduccion(ordenProduccion);
        }

        private void dgvOrdenProduccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                OrdenProduccion ordenProduccion = (OrdenProduccion)dgvOrdenProduccion.Rows[e.RowIndex].DataBoundItem;
                VSeleccionarOPEmergente vista = new VSeleccionarOPEmergente();
                vista.SetOrdenProduccion(ordenProduccion);
                vista.AceptarClicked += IniciarLinea;
                vista.ShowDialog();
            }
        }

        private void DgvOrdenProduccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
