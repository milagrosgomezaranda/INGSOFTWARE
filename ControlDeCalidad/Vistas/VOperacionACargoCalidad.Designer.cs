﻿namespace ControlDeCalidad.Presentacion.Vistas
{
    partial class VOperacionACargoCalidad
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLineaTrabajo = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtNumeroOP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAbandonar = new System.Windows.Forms.Button();
            this.btnHermanado = new System.Windows.Forms.Button();
            this.btnInspeccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(294, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Orden de Producción";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtLineaTrabajo
            // 
            this.txtLineaTrabajo.Enabled = false;
            this.txtLineaTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineaTrabajo.Location = new System.Drawing.Point(208, 138);
            this.txtLineaTrabajo.Name = "txtLineaTrabajo";
            this.txtLineaTrabajo.Size = new System.Drawing.Size(220, 31);
            this.txtLineaTrabajo.TabIndex = 19;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(628, 193);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(220, 31);
            this.txtEstado.TabIndex = 18;
            // 
            // txtNumeroOP
            // 
            this.txtNumeroOP.Enabled = false;
            this.txtNumeroOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOP.Location = new System.Drawing.Point(208, 86);
            this.txtNumeroOP.Name = "txtNumeroOP";
            this.txtNumeroOP.Size = new System.Drawing.Size(220, 31);
            this.txtNumeroOP.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(25, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Línea de Trabajo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(467, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Estado Actual";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(71, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Número OP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(128, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 27);
            this.label5.TabIndex = 20;
            this.label5.Text = "Color";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtColor
            // 
            this.txtColor.Enabled = false;
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(208, 190);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(220, 31);
            this.txtColor.TabIndex = 21;
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(628, 91);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(220, 31);
            this.txtModelo.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(531, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 27);
            this.label6.TabIndex = 22;
            this.label6.Text = "Modelo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.Enabled = false;
            this.txtObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObjetivo.Location = new System.Drawing.Point(628, 138);
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(220, 31);
            this.txtObjetivo.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(460, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 27);
            this.label7.TabIndex = 24;
            this.label7.Text = "Objetivo/Hora";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAbandonar
            // 
            this.btnAbandonar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAbandonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbandonar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbandonar.Location = new System.Drawing.Point(642, 379);
            this.btnAbandonar.Name = "btnAbandonar";
            this.btnAbandonar.Size = new System.Drawing.Size(215, 45);
            this.btnAbandonar.TabIndex = 27;
            this.btnAbandonar.Text = "Abandonar";
            this.btnAbandonar.UseVisualStyleBackColor = false;
            this.btnAbandonar.Click += new System.EventHandler(this.btnAbandonar_Click);
            // 
            // btnHermanado
            // 
            this.btnHermanado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHermanado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHermanado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHermanado.Location = new System.Drawing.Point(465, 276);
            this.btnHermanado.Name = "btnHermanado";
            this.btnHermanado.Size = new System.Drawing.Size(215, 45);
            this.btnHermanado.TabIndex = 26;
            this.btnHermanado.Text = "Hermanar";
            this.btnHermanado.UseVisualStyleBackColor = false;
            this.btnHermanado.Click += new System.EventHandler(this.btnHermanado_Click);
            // 
            // btnInspeccion
            // 
            this.btnInspeccion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnInspeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInspeccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInspeccion.Location = new System.Drawing.Point(235, 276);
            this.btnInspeccion.Name = "btnInspeccion";
            this.btnInspeccion.Size = new System.Drawing.Size(215, 45);
            this.btnInspeccion.TabIndex = 28;
            this.btnInspeccion.Text = "Inspeccionar";
            this.btnInspeccion.UseVisualStyleBackColor = false;
            this.btnInspeccion.Click += new System.EventHandler(this.btnInspeccion_Click);
            // 
            // VOperacionACargoCalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 436);
            this.Controls.Add(this.btnInspeccion);
            this.Controls.Add(this.btnAbandonar);
            this.Controls.Add(this.btnHermanado);
            this.Controls.Add(this.txtObjetivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLineaTrabajo);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNumeroOP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VOperacionACargoCalidad";
            this.Text = "Operación a cargo del Supervisor de Calidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLineaTrabajo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtNumeroOP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObjetivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAbandonar;
        private System.Windows.Forms.Button btnHermanado;
        private System.Windows.Forms.Button btnInspeccion;
    }
}