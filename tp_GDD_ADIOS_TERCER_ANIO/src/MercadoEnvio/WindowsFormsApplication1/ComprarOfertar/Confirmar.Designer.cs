﻿namespace MercadoEnvios.ComprarOfertar
{
    partial class frmConfirmar
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNumeric = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNumeric = new System.Windows.Forms.Label();
            this.lblCantPrecio = new System.Windows.Forms.Label();
            this.lblGanador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(28, 154);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(96, 42);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtNumeric
            // 
            this.txtNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeric.Location = new System.Drawing.Point(84, 107);
            this.txtNumeric.MaxLength = 8;
            this.txtNumeric.Name = "txtNumeric";
            this.txtNumeric.Size = new System.Drawing.Size(96, 26);
            this.txtNumeric.TabIndex = 1;
            this.txtNumeric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(136, 154);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 42);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNumeric
            // 
            this.lblNumeric.AutoSize = true;
            this.lblNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeric.Location = new System.Drawing.Point(96, 9);
            this.lblNumeric.Name = "lblNumeric";
            this.lblNumeric.Size = new System.Drawing.Size(129, 20);
            this.lblNumeric.TabIndex = 3;
            this.lblNumeric.Text = "Precio / Cantidad";
            // 
            // lblCantPrecio
            // 
            this.lblCantPrecio.AutoSize = true;
            this.lblCantPrecio.Location = new System.Drawing.Point(81, 81);
            this.lblCantPrecio.Name = "lblCantPrecio";
            this.lblCantPrecio.Size = new System.Drawing.Size(68, 13);
            this.lblCantPrecio.TabIndex = 4;
            this.lblCantPrecio.Text = "[cant/precio]";
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Location = new System.Drawing.Point(54, 39);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(0, 13);
            this.lblGanador.TabIndex = 30;
            // 
            // frmConfirmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 211);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.lblCantPrecio);
            this.Controls.Add(this.lblNumeric);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNumeric);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "frmConfirmar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar / Ofertar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNumeric;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNumeric;
        private System.Windows.Forms.Label lblCantPrecio;
        private System.Windows.Forms.Label lblGanador;
    }
}