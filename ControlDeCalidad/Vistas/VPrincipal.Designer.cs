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
            this.oPACargoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarParesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informePrimeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeSegundaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.archivoToolStripMenuItem.Text = "Gestión";
            // 
            // gestionColoresToolStripMenuItem
            // 
            this.gestionColoresToolStripMenuItem.Name = "gestionColoresToolStripMenuItem";
            this.gestionColoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionColoresToolStripMenuItem.Text = "Gestion Colores";
            // 
            // gestiónModelosToolStripMenuItem
            // 
            this.gestiónModelosToolStripMenuItem.Name = "gestiónModelosToolStripMenuItem";
            this.gestiónModelosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.oPToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.oPToolStripMenuItem.Text = "Orden de Producción";
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
            // oPACargoToolStripMenuItem1
            // 
            this.oPACargoToolStripMenuItem1.Name = "oPACargoToolStripMenuItem1";
            this.oPACargoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.oPACargoToolStripMenuItem1.Text = "OP A Cargo";
            this.oPACargoToolStripMenuItem1.Click += new System.EventHandler(this.oPACargoToolStripMenuItem1_Click);
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
            this.informePrimeraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informePrimeraToolStripMenuItem.Text = "Informe Primera";
            this.informePrimeraToolStripMenuItem.Click += new System.EventHandler(this.informePrimeraToolStripMenuItem_Click);
            // 
            // informeSegundaToolStripMenuItem
            // 
            this.informeSegundaToolStripMenuItem.Name = "informeSegundaToolStripMenuItem";
            this.informeSegundaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informeSegundaToolStripMenuItem.Text = "Informe Segunda";
            this.informeSegundaToolStripMenuItem.Click += new System.EventHandler(this.informeSegundaToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(227, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(638, 27);
            this.label4.TabIndex = 25;
            this.label4.Text = "Universidad Tecnologica Nacional - Facultad Regional Tucumán";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(355, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cátedra de Ingeniería de Software";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(456, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "Comisión 4K3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(479, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "Grupo 9";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 575);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VPrincipal";
            this.Text = "Ingeniería de Software ";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

