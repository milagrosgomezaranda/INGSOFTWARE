using ControlDeCalidad.Dominio.Entidades;
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
    public partial class VSeleccionarOPEmergente : Form
    {
        public event EventHandler<OrdenProduccion> AceptarClicked;
        private OrdenProduccion _ordenProduccion;
        public VSeleccionarOPEmergente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AceptarClicked?.Invoke(this,_ordenProduccion);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void SetOrdenProduccion(OrdenProduccion ordenProduccion)
        {
            _ordenProduccion = ordenProduccion;
            txtEstado.Text = _ordenProduccion.EstadoOP.ToString();
            txtLineaTrabajo.Text = _ordenProduccion.LineaTrabajo.IdLinea.ToString();
            txtNumeroOP.Text = _ordenProduccion.NumeroOperacion.ToString();
        }
    }
}
