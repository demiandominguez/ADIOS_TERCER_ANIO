﻿namespace WindowsFormsApplication1.ABM_Rol
{
    partial class frmModificarRoles
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
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvFuncionalidadesTotales = new System.Windows.Forms.DataGridView();
            this.NombreDeFuncionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFuncionalidadesActuales = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRoles = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblFuncionalidadesTotales = new System.Windows.Forms.Label();
            this.lblFuncionalidadesActuales = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidadesTotales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidadesActuales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(12, 50);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(131, 13);
            this.lblNuevoNombre.TabIndex = 0;
            this.lblNuevoNombre.Text = "Ingrese un nuevo nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // dgvFuncionalidadesTotales
            // 
            this.dgvFuncionalidadesTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidadesTotales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreDeFuncionalidad});
            this.dgvFuncionalidadesTotales.Location = new System.Drawing.Point(15, 90);
            this.dgvFuncionalidadesTotales.Name = "dgvFuncionalidadesTotales";
            this.dgvFuncionalidadesTotales.Size = new System.Drawing.Size(144, 150);
            this.dgvFuncionalidadesTotales.TabIndex = 2;
            // 
            // NombreDeFuncionalidad
            // 
            this.NombreDeFuncionalidad.HeaderText = "Funcionalidad";
            this.NombreDeFuncionalidad.Name = "NombreDeFuncionalidad";
            // 
            // dgvFuncionalidadesActuales
            // 
            this.dgvFuncionalidadesActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidadesActuales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvFuncionalidadesActuales.Location = new System.Drawing.Point(215, 90);
            this.dgvFuncionalidadesActuales.Name = "dgvFuncionalidadesActuales";
            this.dgvFuncionalidadesActuales.Size = new System.Drawing.Size(144, 150);
            this.dgvFuncionalidadesActuales.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Funcionalidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRoles.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRoles.Location = new System.Drawing.Point(15, 13);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(47, 18);
            this.lblRoles.TabIndex = 4;
            this.lblRoles.Text = "Roles";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(225, 246);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(122, 23);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Quitar funcionalidad";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 246);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar funcionalidad";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFuncionalidadesTotales
            // 
            this.lblFuncionalidadesTotales.AutoSize = true;
            this.lblFuncionalidadesTotales.Location = new System.Drawing.Point(12, 74);
            this.lblFuncionalidadesTotales.Name = "lblFuncionalidadesTotales";
            this.lblFuncionalidadesTotales.Size = new System.Drawing.Size(136, 13);
            this.lblFuncionalidadesTotales.TabIndex = 8;
            this.lblFuncionalidadesTotales.Text = "Listado de Funcionalidades";
            // 
            // lblFuncionalidadesActuales
            // 
            this.lblFuncionalidadesActuales.AutoSize = true;
            this.lblFuncionalidadesActuales.Location = new System.Drawing.Point(215, 73);
            this.lblFuncionalidadesActuales.Name = "lblFuncionalidadesActuales";
            this.lblFuncionalidadesActuales.Size = new System.Drawing.Size(128, 13);
            this.lblFuncionalidadesActuales.TabIndex = 9;
            this.lblFuncionalidadesActuales.Text = "Funcionalidades Actuales";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(83, 290);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(215, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmModificarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 340);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblFuncionalidadesActuales);
            this.Controls.Add(this.lblFuncionalidadesTotales);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblRoles);
            this.Controls.Add(this.dgvFuncionalidadesActuales);
            this.Controls.Add(this.dgvFuncionalidadesTotales);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNuevoNombre);
            this.Name = "frmModificarRoles";
            this.Text = "Modificar Roles";
            this.Load += new System.EventHandler(this.ModificarRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidadesTotales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidadesActuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvFuncionalidadesTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDeFuncionalidad;
        private System.Windows.Forms.DataGridView dgvFuncionalidadesActuales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblFuncionalidadesTotales;
        private System.Windows.Forms.Label lblFuncionalidadesActuales;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
    }
}