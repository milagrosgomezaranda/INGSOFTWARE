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
    public partial class VMensajeIniciarOP : Form
    {
        public event EventHandler AceptarClicked;
        private OrdenProduccion _ordenProduccion;
        public VMensajeIniciarOP()
        {
            InitializeComponent();
        }
        internal void SetOrdenProduccion(OrdenProduccion ordenProduccion)
        {
            _ordenProduccion = ordenProduccion;
            txtLineaTrabajo.Text = _ordenProduccion.LineaTrabajo.IdLinea.ToString();
            txtNumero.Text = _ordenProduccion.NumeroOperacion.ToString();
        }
        public void OnAceptarClicked(object obj,EventArgs e)
        {
            AceptarClicked?.Invoke(this, e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            OnAceptarClicked(sender,e);
            Close();
        }
    }
}
