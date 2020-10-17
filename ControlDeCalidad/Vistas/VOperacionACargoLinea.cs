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
    public partial class VOperacionACargoLinea : Form,IVOperacionACargoLinea
    {
        private PresentadorOperacionACargoLinea _presentador;
        public VOperacionACargoLinea()
        {
            InitializeComponent();
            _presentador = new PresentadorOperacionACargoLinea(RepositorioOrdenProduccion.Instance,this);
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            _presentador.Pausar();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            _presentador.Continuar();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            _presentador.Finalizar();
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
                SetEstado(ordenProduccion.EstadoOP);
            }
            else
            {
                MessageBox.Show("No tiene una Operación a Cargo", "Operación a Cargo", MessageBoxButtons.OK,
                true ? MessageBoxIcon.Error : MessageBoxIcon.Information);
            }
        }

        private void SetEstado(EstadoOP estadoOP)
        {
            switch (estadoOP)
            {
                case EstadoOP.Pausada:
                    btnPausar.Enabled = false;
                    btnFinalizar.Enabled = true;
                    btnContinuar.Enabled = true;
                    break;
                case EstadoOP.EnProceso:
                    btnContinuar.Enabled = false;
                    btnPausar.Enabled = true;
                    btnFinalizar.Enabled = true;
                    break;
                case EstadoOP.Finalizada:
                    btnContinuar.Enabled = false;
                    btnPausar.Enabled = false;
                    btnFinalizar.Enabled = false;
                    break;

            }
        }

        private void VOperacionACargoLinea_Load(object sender, EventArgs e)
        {

        }
    }
}
