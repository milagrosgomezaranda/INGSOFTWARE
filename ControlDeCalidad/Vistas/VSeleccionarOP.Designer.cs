namespace ControlDeCalidad.Presentacion.Vistas
{
    partial class VSeleccionarOP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrdenProduccion = new System.Windows.Forms.DataGridView();
            this.Asignado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numeroOperacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOrdenProduccion = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdenProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvOrdenProduccion);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Orden de Producción";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvOrdenProduccion
            // 
            this.dgvOrdenProduccion.AllowUserToAddRows = false;
            this.dgvOrdenProduccion.AllowUserToDeleteRows = false;
            this.dgvOrdenProduccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrdenProduccion.AutoGenerateColumns = false;
            this.dgvOrdenProduccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdenProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroOperacionDataGridViewTextBoxColumn,
            this.estadoOPDataGridViewTextBoxColumn,
            this.lineaTrabajoDataGridViewTextBoxColumn,
            this.Asignado});
            this.dgvOrdenProduccion.DataSource = this.bsOrdenProduccion;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdenProduccion.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrdenProduccion.Location = new System.Drawing.Point(0, 57);
            this.dgvOrdenProduccion.Name = "dgvOrdenProduccion";
            this.dgvOrdenProduccion.ReadOnly = true;
            this.dgvOrdenProduccion.Size = new System.Drawing.Size(776, 371);
            this.dgvOrdenProduccion.TabIndex = 3;
            this.dgvOrdenProduccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenProduccion_CellClick);
            this.dgvOrdenProduccion.SelectionChanged += new System.EventHandler(this.dgvOrdenProduccion_SelectionChanged);
            // 
            // Asignado
            // 
            this.Asignado.DataPropertyName = "Asignado";
            this.Asignado.HeaderText = "¿SUPERVISOR DE CALIDAD ASIGNADO?";
            this.Asignado.Name = "Asignado";
            this.Asignado.ReadOnly = true;
            // 
            // numeroOperacionDataGridViewTextBoxColumn
            // 
            this.numeroOperacionDataGridViewTextBoxColumn.DataPropertyName = "NumeroOperacion";
            this.numeroOperacionDataGridViewTextBoxColumn.HeaderText = "Nro. OP";
            this.numeroOperacionDataGridViewTextBoxColumn.Name = "numeroOperacionDataGridViewTextBoxColumn";
            this.numeroOperacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoOPDataGridViewTextBoxColumn
            // 
            this.estadoOPDataGridViewTextBoxColumn.DataPropertyName = "EstadoOP";
            this.estadoOPDataGridViewTextBoxColumn.HeaderText = "ESTADO ACTUAL";
            this.estadoOPDataGridViewTextBoxColumn.Name = "estadoOPDataGridViewTextBoxColumn";
            this.estadoOPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineaTrabajoDataGridViewTextBoxColumn
            // 
            this.lineaTrabajoDataGridViewTextBoxColumn.DataPropertyName = "LineaTrabajo";
            this.lineaTrabajoDataGridViewTextBoxColumn.HeaderText = "Línea";
            this.lineaTrabajoDataGridViewTextBoxColumn.Name = "lineaTrabajoDataGridViewTextBoxColumn";
            this.lineaTrabajoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsOrdenProduccion
            // 
            this.bsOrdenProduccion.DataSource = typeof(ControlDeCalidad.Dominio.Entidades.OrdenProduccion);
            // 
            // VSeleccionarOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "VSeleccionarOP";
            this.Text = "VSeleccionarOP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdenProduccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsOrdenProduccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrdenProduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroOperacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Asignado;
    }
}