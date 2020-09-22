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
    public partial class VIniciarOP : Form, IVistaIniciarOP
    {
        private PresentadorIniciarOP _presentador;
        public VIniciarOP()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            _presentador = new PresentadorIniciarOP(this, new RepositorioModelo(), new RepositorioColor(), new RepositorioUsuario(), RepositorioOrdenProduccion.Instance);
            _presentador.Iniciar();
        }

        public void PoblarModelos(List<Modelo> modelos)
        {
            cbModelo.DataSource = modelos;
        }

        public void PoblarColores(List<Dominio.Entidades.Color> colores)
        {
            cbColor.DataSource = colores;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (_presentador.Validar())
            {
                OrdenProduccion ordenProduccion = _presentador.Finalizar();
                if (ordenProduccion != null)
                {
                    VMensajeIniciarOP vista = new VMensajeIniciarOP();
                    vista.SetOrdenProduccion(ordenProduccion);
                    vista.AceptarClicked += VIniciarClose;
                    vista.ShowDialog();
                }
            }
        }
        public void VIniciarClose(object sender,EventArgs e)
        {
            Close();
        }

        public void PoblarSupervisorCalidad(List<SupCalidad> usuarios)
        {
            cbSC.DataSource = usuarios;
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbColor.SelectedItem != null)
            {
                _presentador.SeleccionarColor((Dominio.Entidades.Color)cbColor.SelectedItem);
            }
        }
        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbModelo.SelectedItem != null)
            {
                _presentador.SeleccionarModelo((Modelo)cbModelo.SelectedItem);
            }
        }

        private void txtObjetivo_TextChanged(object sender, EventArgs e)
        {
            if(txtObjetivo.Text != "")
            {
                _presentador.IngresarObjetivo(Int32.Parse(txtObjetivo.Text));
            }
        }

        private void cbSC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSC.SelectedItem != null)
            {
                _presentador.SeleccionarSC((SupCalidad)cbSC.SelectedItem);
            }
        }
    }
}
