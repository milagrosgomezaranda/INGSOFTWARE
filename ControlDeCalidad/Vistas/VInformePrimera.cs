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
    public partial class VInformePrimera : Form, IVInformePrimera
    {
        private PresentadorInformePrimera _presentador;
        public VInformePrimera()
        {
            InitializeComponent();
            _presentador = new PresentadorInformePrimera(this, RepositorioOrdenProduccion.Instance);
            _presentador.Iniciar();
        }

        public void SetInformePrimera(OrdenProduccion ordenProduccion)
        {
            txtNumeroOP.Text = ordenProduccion.NumeroOperacion.ToString();
            txtModelo.Text = ordenProduccion.Modelo.ToString();
            txtColor.Text = ordenProduccion.Modelo.Color.ToString();
            txtEstado.Text = ordenProduccion.EstadoOP.ToString();
            txtLineaTrabajo.Text = ordenProduccion.LineaTrabajo.ToString();                                   
            txtObjetivo.Text = ordenProduccion.Objetivo.ToString();

            int Hours = Math.Abs(ordenProduccion.Turno.HoraFin.Subtract(ordenProduccion.Turno.HoraInicio).Hours);

            for (int i = 0; i < Hours; i++)
            {
                dgvHoras.Columns.Add("", ordenProduccion.Turno.HoraInicio.AddHours(i).ToString());
            }
            int j = 0;
            foreach (KeyValuePair<int, int> result in ordenProduccion.InformePrimera.Horas)
            {
                dgvHoras.Rows[0].Cells[j].Value = result.Value;
                j++;
            }
            txtTotal.Text = ordenProduccion.InformePrimera.TotalPares.ToString();
        }
    }
}
