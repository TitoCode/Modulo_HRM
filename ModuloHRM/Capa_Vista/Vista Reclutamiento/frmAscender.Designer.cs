﻿namespace Capa_Vista.Vista_Reclutamiento
{
    partial class frmAscender
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
            this.gbxNuevoCargo = new System.Windows.Forms.GroupBox();
            this.cmbDepartamentoNuevo = new System.Windows.Forms.ComboBox();
            this.lblPuestoNuevo = new System.Windows.Forms.Label();
            this.cmbPuestoNuevo = new System.Windows.Forms.ComboBox();
            this.lblDepartamentoNuevo = new System.Windows.Forms.Label();
            this.gbxAntiguoCargo = new System.Windows.Forms.GroupBox();
            this.cmbDepartamentoAnterior = new System.Windows.Forms.ComboBox();
            this.lblPuestoAnterior = new System.Windows.Forms.Label();
            this.lblDepartamentoTrabajoAnterior = new System.Windows.Forms.Label();
            this.cmbPuestoAnterior = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.lblIngreseIdEmpleado = new System.Windows.Forms.Label();
            this.pnlDatosGenerales = new System.Windows.Forms.Panel();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.btnAscender = new System.Windows.Forms.Button();
            this.pnlAscensos = new System.Windows.Forms.Panel();
            this.gbxNuevoCargo.SuspendLayout();
            this.gbxAntiguoCargo.SuspendLayout();
            this.pnlDatosGenerales.SuspendLayout();
            this.pnlAscensos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxNuevoCargo
            // 
            this.gbxNuevoCargo.Controls.Add(this.cmbDepartamentoNuevo);
            this.gbxNuevoCargo.Controls.Add(this.lblPuestoNuevo);
            this.gbxNuevoCargo.Controls.Add(this.cmbPuestoNuevo);
            this.gbxNuevoCargo.Controls.Add(this.lblDepartamentoNuevo);
            this.gbxNuevoCargo.Enabled = false;
            this.gbxNuevoCargo.Location = new System.Drawing.Point(677, 94);
            this.gbxNuevoCargo.Name = "gbxNuevoCargo";
            this.gbxNuevoCargo.Size = new System.Drawing.Size(200, 196);
            this.gbxNuevoCargo.TabIndex = 30;
            this.gbxNuevoCargo.TabStop = false;
            this.gbxNuevoCargo.Text = "Nuevo Cargo";
            // 
            // cmbDepartamentoNuevo
            // 
            this.cmbDepartamentoNuevo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDepartamentoNuevo.FormattingEnabled = true;
            this.cmbDepartamentoNuevo.Location = new System.Drawing.Point(6, 142);
            this.cmbDepartamentoNuevo.Name = "cmbDepartamentoNuevo";
            this.cmbDepartamentoNuevo.Size = new System.Drawing.Size(175, 28);
            this.cmbDepartamentoNuevo.TabIndex = 34;
            // 
            // lblPuestoNuevo
            // 
            this.lblPuestoNuevo.AutoSize = true;
            this.lblPuestoNuevo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoNuevo.Location = new System.Drawing.Point(6, 26);
            this.lblPuestoNuevo.Name = "lblPuestoNuevo";
            this.lblPuestoNuevo.Size = new System.Drawing.Size(62, 20);
            this.lblPuestoNuevo.TabIndex = 32;
            this.lblPuestoNuevo.Text = "Puesto";
            // 
            // cmbPuestoNuevo
            // 
            this.cmbPuestoNuevo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPuestoNuevo.FormattingEnabled = true;
            this.cmbPuestoNuevo.Location = new System.Drawing.Point(6, 57);
            this.cmbPuestoNuevo.Name = "cmbPuestoNuevo";
            this.cmbPuestoNuevo.Size = new System.Drawing.Size(175, 28);
            this.cmbPuestoNuevo.TabIndex = 33;
            // 
            // lblDepartamentoNuevo
            // 
            this.lblDepartamentoNuevo.AutoSize = true;
            this.lblDepartamentoNuevo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoNuevo.Location = new System.Drawing.Point(6, 103);
            this.lblDepartamentoNuevo.Name = "lblDepartamentoNuevo";
            this.lblDepartamentoNuevo.Size = new System.Drawing.Size(121, 20);
            this.lblDepartamentoNuevo.TabIndex = 31;
            this.lblDepartamentoNuevo.Text = "Departamento";
            // 
            // gbxAntiguoCargo
            // 
            this.gbxAntiguoCargo.Controls.Add(this.cmbDepartamentoAnterior);
            this.gbxAntiguoCargo.Controls.Add(this.lblPuestoAnterior);
            this.gbxAntiguoCargo.Controls.Add(this.lblDepartamentoTrabajoAnterior);
            this.gbxAntiguoCargo.Controls.Add(this.cmbPuestoAnterior);
            this.gbxAntiguoCargo.Enabled = false;
            this.gbxAntiguoCargo.Location = new System.Drawing.Point(459, 88);
            this.gbxAntiguoCargo.Name = "gbxAntiguoCargo";
            this.gbxAntiguoCargo.Size = new System.Drawing.Size(193, 198);
            this.gbxAntiguoCargo.TabIndex = 29;
            this.gbxAntiguoCargo.TabStop = false;
            this.gbxAntiguoCargo.Text = "Antiguo Cargo";
            // 
            // cmbDepartamentoAnterior
            // 
            this.cmbDepartamentoAnterior.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDepartamentoAnterior.FormattingEnabled = true;
            this.cmbDepartamentoAnterior.Location = new System.Drawing.Point(6, 150);
            this.cmbDepartamentoAnterior.Name = "cmbDepartamentoAnterior";
            this.cmbDepartamentoAnterior.Size = new System.Drawing.Size(175, 28);
            this.cmbDepartamentoAnterior.TabIndex = 30;
            // 
            // lblPuestoAnterior
            // 
            this.lblPuestoAnterior.AutoSize = true;
            this.lblPuestoAnterior.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoAnterior.Location = new System.Drawing.Point(6, 34);
            this.lblPuestoAnterior.Name = "lblPuestoAnterior";
            this.lblPuestoAnterior.Size = new System.Drawing.Size(62, 20);
            this.lblPuestoAnterior.TabIndex = 19;
            this.lblPuestoAnterior.Text = "Puesto";
            // 
            // lblDepartamentoTrabajoAnterior
            // 
            this.lblDepartamentoTrabajoAnterior.AutoSize = true;
            this.lblDepartamentoTrabajoAnterior.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoTrabajoAnterior.Location = new System.Drawing.Point(6, 105);
            this.lblDepartamentoTrabajoAnterior.Name = "lblDepartamentoTrabajoAnterior";
            this.lblDepartamentoTrabajoAnterior.Size = new System.Drawing.Size(121, 20);
            this.lblDepartamentoTrabajoAnterior.TabIndex = 18;
            this.lblDepartamentoTrabajoAnterior.Text = "Departamento";
            // 
            // cmbPuestoAnterior
            // 
            this.cmbPuestoAnterior.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPuestoAnterior.FormattingEnabled = true;
            this.cmbPuestoAnterior.Location = new System.Drawing.Point(6, 65);
            this.cmbPuestoAnterior.Name = "cmbPuestoAnterior";
            this.cmbPuestoAnterior.Size = new System.Drawing.Size(175, 28);
            this.cmbPuestoAnterior.TabIndex = 29;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(603, 35);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 30);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdEmpleado.Location = new System.Drawing.Point(423, 35);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(148, 27);
            this.txtIdEmpleado.TabIndex = 26;
            this.txtIdEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // lblIngreseIdEmpleado
            // 
            this.lblIngreseIdEmpleado.AutoSize = true;
            this.lblIngreseIdEmpleado.Location = new System.Drawing.Point(161, 38);
            this.lblIngreseIdEmpleado.Name = "lblIngreseIdEmpleado";
            this.lblIngreseIdEmpleado.Size = new System.Drawing.Size(222, 20);
            this.lblIngreseIdEmpleado.TabIndex = 27;
            this.lblIngreseIdEmpleado.Text = "Ingrese el ID del Empleado";
            // 
            // pnlDatosGenerales
            // 
            this.pnlDatosGenerales.Controls.Add(this.txtPrimerApellido);
            this.pnlDatosGenerales.Controls.Add(this.lblSegundoApellido);
            this.pnlDatosGenerales.Controls.Add(this.txtSegundoApellido);
            this.pnlDatosGenerales.Controls.Add(this.txtPrimerNombre);
            this.pnlDatosGenerales.Controls.Add(this.txtSegundoNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblSegundoNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblPrimerNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblPrimerApellido);
            this.pnlDatosGenerales.Enabled = false;
            this.pnlDatosGenerales.Location = new System.Drawing.Point(10, 94);
            this.pnlDatosGenerales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDatosGenerales.Name = "pnlDatosGenerales";
            this.pnlDatosGenerales.Size = new System.Drawing.Size(417, 192);
            this.pnlDatosGenerales.TabIndex = 22;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerApellido.Location = new System.Drawing.Point(200, 102);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(184, 27);
            this.txtPrimerApellido.TabIndex = 7;
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(13, 149);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(149, 20);
            this.lblSegundoApellido.TabIndex = 4;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSegundoApellido.Location = new System.Drawing.Point(200, 145);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(184, 27);
            this.txtSegundoApellido.TabIndex = 8;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerNombre.Location = new System.Drawing.Point(200, 16);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(184, 27);
            this.txtPrimerNombre.TabIndex = 5;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSegundoNombre.Location = new System.Drawing.Point(200, 61);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(184, 27);
            this.txtSegundoNombre.TabIndex = 6;
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(13, 64);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(146, 20);
            this.lblSegundoNombre.TabIndex = 2;
            this.lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.Location = new System.Drawing.Point(13, 18);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(131, 20);
            this.lblPrimerNombre.TabIndex = 1;
            this.lblPrimerNombre.Text = "Primer Nombre";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(13, 105);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(138, 20);
            this.lblPrimerApellido.TabIndex = 3;
            this.lblPrimerApellido.Text = "Primer Apellido ";
            // 
            // btnAscender
            // 
            this.btnAscender.Enabled = false;
            this.btnAscender.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscender.Location = new System.Drawing.Point(735, 367);
            this.btnAscender.Name = "btnAscender";
            this.btnAscender.Size = new System.Drawing.Size(161, 50);
            this.btnAscender.TabIndex = 22;
            this.btnAscender.Text = "Ascender";
            this.btnAscender.UseVisualStyleBackColor = true;
            this.btnAscender.Click += new System.EventHandler(this.btnAscender_Click);
            // 
            // pnlAscensos
            // 
            this.pnlAscensos.Controls.Add(this.txtIdEmpleado);
            this.pnlAscensos.Controls.Add(this.pnlDatosGenerales);
            this.pnlAscensos.Controls.Add(this.gbxAntiguoCargo);
            this.pnlAscensos.Controls.Add(this.gbxNuevoCargo);
            this.pnlAscensos.Controls.Add(this.lblIngreseIdEmpleado);
            this.pnlAscensos.Controls.Add(this.btnBuscar);
            this.pnlAscensos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAscensos.Location = new System.Drawing.Point(2, 2);
            this.pnlAscensos.Name = "pnlAscensos";
            this.pnlAscensos.Size = new System.Drawing.Size(894, 343);
            this.pnlAscensos.TabIndex = 31;
            // 
            // frmAscender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(111)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(900, 429);
            this.Controls.Add(this.pnlAscensos);
            this.Controls.Add(this.btnAscender);
            this.Name = "frmAscender";
            this.Text = "frmAscender";
            this.Load += new System.EventHandler(this.frmAscender_Load);
            this.gbxNuevoCargo.ResumeLayout(false);
            this.gbxNuevoCargo.PerformLayout();
            this.gbxAntiguoCargo.ResumeLayout(false);
            this.gbxAntiguoCargo.PerformLayout();
            this.pnlDatosGenerales.ResumeLayout(false);
            this.pnlDatosGenerales.PerformLayout();
            this.pnlAscensos.ResumeLayout(false);
            this.pnlAscensos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label lblIngreseIdEmpleado;
        private System.Windows.Forms.ComboBox cmbDepartamentoAnterior;
        private System.Windows.Forms.Label lblPuestoAnterior;
        private System.Windows.Forms.ComboBox cmbPuestoAnterior;
        private System.Windows.Forms.Label lblDepartamentoTrabajoAnterior;
        private System.Windows.Forms.Button btnAscender;
        private System.Windows.Forms.Panel pnlDatosGenerales;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.GroupBox gbxNuevoCargo;
        private System.Windows.Forms.GroupBox gbxAntiguoCargo;
        private System.Windows.Forms.ComboBox cmbDepartamentoNuevo;
        private System.Windows.Forms.Label lblPuestoNuevo;
        private System.Windows.Forms.ComboBox cmbPuestoNuevo;
        private System.Windows.Forms.Label lblDepartamentoNuevo;
        private System.Windows.Forms.Panel pnlAscensos;
    }
}