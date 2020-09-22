using ControlDeCalidad.AccesoADatos;
using ControlDeCalidad.Dominio.Entidades;
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
    public partial class VInspeccion : Form,IVRegistrarPares
    {
        private delegate void OpcionSeleccionada();
        private OpcionSeleccionada handler;
        private PresentadorRegistrarPares _presentador;
        public VInspeccion()
        {
            InitializeComponent();
            _presentador = new PresentadorRegistrarPares(RepositorioOrdenProduccion.Instance,this,new RepositorioDefectos());
            Iniciar();
        }

        public void SetOrdenProduccion(OrdenProduccion ordenProduccion)
        {
            txtNumeroOP.Text = ordenProduccion.NumeroOperacion.ToString();
            txtLineaTrabajo.Text = ordenProduccion.LineaTrabajo.ToString();
            txtModelo.Text = ordenProduccion.Modelo.ToString();
            txtColor.Text = ordenProduccion.Modelo.Color.ToString();
            txtObjetivo.Text = ordenProduccion.Objetivo.ToString();
            txtEstado.Text = ordenProduccion.EstadoOP.ToString();
        }

        private void Iniciar()
        {            
            cbPieDerecho.Enabled = false;
            cbPieIzquierdo.Enabled = false;
            btnActualizar.Enabled = false;
            _presentador.Iniciar();
        }

        private void cboxParPrimera_CheckedChanged(object sender, EventArgs e)
        {
            cboxParSegunda.Checked = false;
            cboxReproceso.Checked = false;
            cbPieIzquierdo.Enabled = false;
            cbPieDerecho.Enabled = false;
            btnActualizar.Enabled = true;
            handler = RegistrarParPrimera;
        }

        private void cboxReproceso_CheckedChanged(object sender, EventArgs e)
        {
            cboxParPrimera.Checked = false;
            cboxParSegunda.Checked = false;
            cbPieIzquierdo.Enabled = true;
            cbPieDerecho.Enabled = true;
            btnActualizar.Enabled = true;
            handler = RegistrarReproceso;
        }

        private void cboxParSegunda_CheckedChanged(object sender, EventArgs e)
        {
            cboxParPrimera.Checked = false;
            cboxReproceso.Checked = false;
            cbPieIzquierdo.Enabled = false;
            cbPieDerecho.Enabled = false;
            btnActualizar.Enabled = true;
            handler = RegistrarParSegunda;
        }

        private void RegistrarParPrimera()
        {
            _presentador.RegistrarParPrimera();
        }
        private void RegistrarParSegunda()
        {
            _presentador.RegistrarParSegunda();
        }
        private void RegistrarReproceso()
        {
            _presentador.RegistrarReproceso((Defectos)cbPieIzquierdo.SelectedItem,(Defectos)cbPieDerecho.SelectedItem);
        }

        public void LimpiarVentana()
        {
            cbPieDerecho.Enabled = false;
            cbPieIzquierdo.Enabled = false;

            cboxParPrimera.Checked = false;
            cboxParSegunda.Checked = false;
            cboxReproceso.Checked = false;
            btnActualizar.Enabled = false;
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            handler();
        }

        public void PoblarComboBox(List<Defectos> pieIzquierdo, List<Defectos> pieDerecho)
        {
            cbPieDerecho.DataSource = pieDerecho;
            cbPieIzquierdo.DataSource = pieIzquierdo;
        }
    }
}
