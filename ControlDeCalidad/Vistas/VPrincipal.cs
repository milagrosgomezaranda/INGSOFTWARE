using ControlDeCalidad.AccesoADatos;
using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Presentacion.Presentadores;
using ControlDeCalidad.Presentacion.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeCalidad.Vistas
{
    public partial class VPrincipal : Form, IVistaPrincipal
    {
        public event EventHandler FormClose;
        private PresentadorPrincipal _presentador;
        public VPrincipal()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            IsMdiContainer = true;
            DeshabilitarMenu();
            if (typeof(SupCalidad).Equals(Sesion.Instance.UsuarioLogueado.GetType()))
            {
                PermisosSupCalidad();
            }
            if (typeof(SupLinea).Equals(Sesion.Instance.UsuarioLogueado.GetType()))
            {
                PermisosSupLinea();
            }
            _presentador = new PresentadorPrincipal(this,RepositorioOrdenProduccion.Instance);
        }

        private void PermisosSupLinea()
        {
            iniciarOPToolStripMenuItem.Enabled = true;
            iniciarOPToolStripMenuItem.Visible = true;

            oPACargoToolStripMenuItem.Enabled = true;
            oPACargoToolStripMenuItem.Visible = true;

            informePrimeraToolStripMenuItem.Enabled = true;
            informePrimeraToolStripMenuItem.Visible = true;
            informeSegundaToolStripMenuItem.Enabled = true;
            informeSegundaToolStripMenuItem.Visible = true;
        }

        private void DeshabilitarMenu()
        {
            gestionColoresToolStripMenuItem.Enabled = false;
            gestionColoresToolStripMenuItem.Visible = false;
            gestiónModelosToolStripMenuItem.Enabled = false;
            gestiónModelosToolStripMenuItem.Visible = false;

            iniciarOPToolStripMenuItem.Enabled = false;
            iniciarOPToolStripMenuItem.Visible = false;
            listarOPToolStripMenuItem.Enabled = false;
            listarOPToolStripMenuItem.Visible = false;

            oPACargoToolStripMenuItem.Enabled = false;
            oPACargoToolStripMenuItem.Visible = false;
            oPACargoToolStripMenuItem1.Enabled = false;
            oPACargoToolStripMenuItem1.Visible = false;            

            registrarParesToolStripMenuItem.Enabled = false;
            registrarParesToolStripMenuItem.Visible = false;

            informePrimeraToolStripMenuItem.Enabled = false;
            informePrimeraToolStripMenuItem.Visible = false;
            informeSegundaToolStripMenuItem.Enabled = false;
            informeSegundaToolStripMenuItem.Visible = false;
        }

        private void PermisosSupCalidad()
        {
            listarOPToolStripMenuItem.Enabled = true;
            listarOPToolStripMenuItem.Visible = true;
            registrarParesToolStripMenuItem.Enabled = true;
            registrarParesToolStripMenuItem.Visible = true;
            oPACargoToolStripMenuItem1.Enabled = true;
            oPACargoToolStripMenuItem1.Visible = true;
        }

        private void iniciarOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_presentador.TieneOrdenACargo())
            {
                VIniciarOP vista = new VIniciarOP();
                vista.MdiParent = this;
                vista?.Show();
            }
            else
            {
                MessageBox.Show("Ya posee una Linea a Cargo", "Iniciar OP", MessageBoxButtons.OK,
                true ? MessageBoxIcon.Error : MessageBoxIcon.Information);
            }
        }

        private void VPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClose?.Invoke(this,e);
            Dispose();
        }

        private void listarOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_presentador.TieneOrdenACargo())
            {
                VSeleccionarOP vista = new VSeleccionarOP();
                vista.MdiParent = this;
                vista.Show();
            }
            else
            {
                MessageBox.Show("Ya posee una Linea a Cargo", "OP A Cargo", MessageBoxButtons.OK,
                true ? MessageBoxIcon.Error : MessageBoxIcon.Information);
            }
        }

        private void oPACargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_presentador.TieneOrdenACargo())
            {
                VOperacionACargoLinea vista = new VOperacionACargoLinea();
                vista.MdiParent = this;
                vista.Show();
            }
            else
            {
                MessageBox.Show("No posee una Línea a cargo", "OP A Cargo", MessageBoxButtons.OK,
                true ? MessageBoxIcon.Error : MessageBoxIcon.Information);
            }            
        }
        private void oPACargoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_presentador.TieneOrdenACargo())
            {
                VOperacionACargoCalidad vista = new VOperacionACargoCalidad();
                vista.MdiParent = this;
                vista.Show();
            }
            else
            {
                MessageBox.Show("No posee un OP a cargo", "OP A Cargo", MessageBoxButtons.OK,
                true ? MessageBoxIcon.Error : MessageBoxIcon.Information);
            }                
        }

        private void registrarParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_presentador.TieneOrdenACargo())
            {
                VInspeccion vista = new VInspeccion();
                vista.MdiParent = this;
                vista.Show();
            }
            else
            {
                MessageBox.Show("No posee un OP a cargo", "OP A Cargo", MessageBoxButtons.OK,
                true ? MessageBoxIcon.Error : MessageBoxIcon.Information);
            }                
        }

        private void informePrimeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VInformePrimera vista = new VInformePrimera();
            vista.MdiParent = this;
            vista.Show();
        }

        private void informeSegundaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VInformeSegunda vista = new VInformeSegunda();
            vista.MdiParent = this;
            vista.Show();
        }        
    }
}
