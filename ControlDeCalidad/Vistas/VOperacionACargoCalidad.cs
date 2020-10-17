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
    public partial class VOperacionACargoCalidad : Form,IVOperacionACargoCalidad
    {
        private PresentadorOperacionACargoCalidad _presentador;
        public VOperacionACargoCalidad()
        {
            InitializeComponent();
            _presentador = new PresentadorOperacionACargoCalidad(RepositorioOrdenProduccion.Instance,this);
            _presentador.Iniciar();
        }

        public void DevolverOperacionACargo(OrdenProduccion ordenProduccion)
        {
            if (ordenProduccion != null)
            {
                txtColor.Text = ordenProduccion.Modelo.Color.ToString();
                txtEstado.Text = ordenProduccion.EstadoOP.ToString();
                txtLineaTrabajo.Text = ordenProduccion.LineaTrabajo.IdLinea.ToString();
                txtModelo.Text = ordenProduccion.Modelo.ToString();
                txtObjetivo.Text = ordenProduccion.Objetivo.ToString();
                txtNumeroOP.Text = ordenProduccion.NumeroOperacion.ToString();
            }
            else
            {
                MessageBox.Show("No tiene una Operación a Cargo", "Operación a Cargo", MessageBoxButtons.OK,
                true ? MessageBoxIcon.Error : MessageBoxIcon.Information);
            }
        }

        private void btnInspeccion_Click(object sender, EventArgs e)
        {
            VInspeccion vista = new VInspeccion();
            vista.ShowDialog();
        }

        private void btnHermanado_Click(object sender, EventArgs e)
        {
            VHermanado vista = new VHermanado();
            vista.ShowDialog();
        }

        private void btnAbandonar_Click(object sender, EventArgs e)
        {
            if (_presentador.AbandonarOP())
            {
                Close();
            }
            else
            {
                MessageBox.Show("No se pudo abandonar la OP", "Operación a Cargo", MessageBoxButtons.OK,
                true ? MessageBoxIcon.Error : MessageBoxIcon.Information);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
