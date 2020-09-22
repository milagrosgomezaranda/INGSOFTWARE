using ControlDeCalidad.AccesoADatos;
using ControlDeCalidad.Dominio.Interfaces;
using ControlDeCalidad.Presentacion.Interfaces;
using ControlDeCalidad.Presentacion.Presentadores;
using ControlDeCalidad.Vistas;
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
    public partial class VLogin : Form,IVistaLogin
    {
        private PresentadorLogin _presentador;
        public VLogin()
        {
            InitializeComponent();
            _presentador = new PresentadorLogin(this,new RepositorioUsuario());
        }

        private void tbUsuario_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "USUARIO")
            {
                tbUsuario.Text = "";
            }            
        }

        private void tbContraseña_Click(object sender, EventArgs e)
        {
            if (tbContraseña.Text == "CONTRASEÑA")
            {
                tbContraseña.Text = "";
            }            
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "")
            {
                tbUsuario.Text = "USUARIO";
            }
        }

        private void tbContraseña_Leave(object sender, EventArgs e)
        {
            if (tbContraseña.Text == "")
            {
                tbContraseña.Text = "CONTRASEÑA";
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool login = _presentador.Login(tbUsuario.Text,tbContraseña.Text);
            if (login)
            {
                VPrincipal vista = new VPrincipal();
                vista.FormClose += DevuelveControl;
                vista?.Show();
                Visible = false;
            }
        }
        public void DevuelveControl(object obj, EventArgs e)
        {
            tbUsuario.Text = "USUARIO";
            tbContraseña.Text = "CONTRASEÑA";
            Visible = true;
        }
    }
}
