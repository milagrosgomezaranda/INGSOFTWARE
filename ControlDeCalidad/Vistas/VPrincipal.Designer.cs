namespace ControlDeCalidad.Vistas
{
    partial class VPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionColoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónModelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPACargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarParesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informePrimeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeSegundaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPACargoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.oPToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1039, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionColoresToolStripMenuItem,
            this.gestiónModelosToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // gestionColoresToolStripMenuItem
            // 
            this.gestionColoresToolStripMenuItem.Name = "gestionColoresToolStripMenuItem";
            this.gestionColoresToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.gestionColoresToolStripMenuItem.Text = "Gestion Colores";
            // 
            // gestiónModelosToolStripMenuItem
            // 
            this.gestiónModelosToolStripMenuItem.Name = "gestiónModelosToolStripMenuItem";
            this.gestiónModelosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.gestiónModelosToolStripMenuItem.Text = "Gestión Modelos";
            // 
            // oPToolStripMenuItem
            // 
            this.oPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarOPToolStripMenuItem,
            this.listarOPToolStripMenuItem,
            this.oPACargoToolStripMenuItem,
            this.oPACargoToolStripMenuItem1,
            this.registrarParesToolStripMenuItem});
            this.oPToolStripMenuItem.Name = "oPToolStripMenuItem";
            this.oPToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.oPToolStripMenuItem.Text = "OP";
            // 
            // iniciarOPToolStripMenuItem
            // 
            this.iniciarOPToolStripMenuItem.Name = "iniciarOPToolStripMenuItem";
            this.iniciarOPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iniciarOPToolStripMenuItem.Text = "Iniciar OP";
            this.iniciarOPToolStripMenuItem.Click += new System.EventHandler(this.iniciarOPToolStripMenuItem_Click);
            // 
            // listarOPToolStripMenuItem
            // 
            this.listarOPToolStripMenuItem.Name = "listarOPToolStripMenuItem";
            this.listarOPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarOPToolStripMenuItem.Text = "Seleccionar OP";
            this.listarOPToolStripMenuItem.Click += new System.EventHandler(this.listarOPToolStripMenuItem_Click);
            // 
            // oPACargoToolStripMenuItem
            // 
            this.oPACargoToolStripMenuItem.Name = "oPACargoToolStripMenuItem";
            this.oPACargoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oPACargoToolStripMenuItem.Text = "OP A Cargo";
            this.oPACargoToolStripMenuItem.Click += new System.EventHandler(this.oPACargoToolStripMenuItem_Click);
            // 
            // registrarParesToolStripMenuItem
            // 
            this.registrarParesToolStripMenuItem.Name = "registrarParesToolStripMenuItem";
            this.registrarParesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarParesToolStripMenuItem.Text = "Registrar Pares";
            this.registrarParesToolStripMenuItem.Click += new System.EventHandler(this.registrarParesToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informePrimeraToolStripMenuItem,
            this.informeSegundaToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // informePrimeraToolStripMenuItem
            // 
            this.informePrimeraToolStripMenuItem.Name = "informePrimeraToolStripMenuItem";
            this.informePrimeraToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.informePrimeraToolStripMenuItem.Text = "Informe Primera";
            this.informePrimeraToolStripMenuItem.Click += new System.EventHandler(this.informePrimeraToolStripMenuItem_Click);
            // 
            // informeSegundaToolStripMenuItem
            // 
            this.informeSegundaToolStripMenuItem.Name = "informeSegundaToolStripMenuItem";
            this.informeSegundaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.informeSegundaToolStripMenuItem.Text = "Informe Segunda";
            this.informeSegundaToolStripMenuItem.Click += new System.EventHandler(this.informeSegundaToolStripMenuItem_Click);
            // 
            // oPACargoToolStripMenuItem1
            // 
            this.oPACargoToolStripMenuItem1.Name = "oPACargoToolStripMenuItem1";
            this.oPACargoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.oPACargoToolStripMenuItem1.Text = "OP A Cargo";
            this.oPACargoToolStripMenuItem1.Click += new System.EventHandler(this.oPACargoToolStripMenuItem1_Click);
            // 
            // VPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 575);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VPrincipal";
            this.Text = "Control de Calidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionColoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónModelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarOPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarOPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPACargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarParesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informePrimeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeSegundaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPACargoToolStripMenuItem1;
    }
}

