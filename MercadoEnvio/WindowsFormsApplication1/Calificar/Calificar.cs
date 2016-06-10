﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.Calificar
{
    public partial class frmCalificacion : Form
    {
        Conexion conn = Conexion.Instance;
        Entidades.Utilidades funciones = new Entidades.Utilidades();
        SqlDataAdapter da;

        public frmCalificacion()
        {
            InitializeComponent();
            this.getData();
        }

        private void getData()
        {
            SqlParameter idCalificador = new SqlParameter("@idCalificador", SqlDbType.Int);
            idCalificador.SqlValue = 17;
            idCalificador.Direction = ParameterDirection.Input;            

            String cmd = "ADIOS_TERCER_ANIO.obtenerCompras";

            da = new SqlDataAdapter(cmd, conn.getConexion);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(idCalificador);
            da.SelectCommand.ExecuteNonQuery();

            DataTable tablaDeCompras = new DataTable("Compras");
            da.Fill(tablaDeCompras);
            dgvCompras.DataSource = tablaDeCompras;
            dgvCompras.Columns[0].Width = 100;
            dgvCompras.Columns[1].Width = 200;
            dgvCompras.Columns[2].Visible = false;
            dgvCompras.Columns[3].Width = 200;
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.AllowUserToDeleteRows = false;
            dgvCompras.ReadOnly = true;
        }


        private void tkbCalificacion_Scroll(object sender, EventArgs e)
        {
            lblEstrellas.Text = tkbCalificacion.Value + " estrellas.";
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            StringBuilder mensaje = new StringBuilder();
            funciones.validarNoVacio(tkbCalificacion, mensaje);
            funciones.validarNoVacio(lblIdCompra, mensaje);

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cargarCalificacion = new SqlCommand("ADIOS_TERCER_ANIO.cargarCalificacion", conn.getConexion);
                cargarCalificacion.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter detalle = new SqlParameter("@detalle", SqlDbType.NVarChar, 255);
                detalle.Direction = ParameterDirection.Input;
                detalle.SqlValue = txtDetalle.Text;

                SqlParameter puntaje = new SqlParameter("@puntaje", SqlDbType.Int);
                puntaje.Direction = ParameterDirection.Input;
                puntaje.SqlValue = Convert.ToInt32(tkbCalificacion.Value);

                SqlParameter idCompra = new SqlParameter("@idCompra", SqlDbType.Int);
                idCompra.Direction = ParameterDirection.Input;
                idCompra.SqlValue = Convert.ToInt32(lblIdCompra.Text);
                
                SqlParameter fecha = new SqlParameter("@fecha", DateTime.Now);
                fecha.Direction = ParameterDirection.Input;
                fecha.SqlDbType = SqlDbType.DateTime;

                cargarCalificacion.Parameters.Add(idCompra);
                cargarCalificacion.Parameters.Add(puntaje);
                cargarCalificacion.Parameters.Add(fecha);
                cargarCalificacion.Parameters.Add(detalle);

                try
                {
                    cargarCalificacion.ExecuteNonQuery();
                    this.getData();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnReputacion_Click(object sender, EventArgs e)
        {
            new frmHistorial().Show();
            this.Hide(); //VOY A QUERER QUE VUELVA
        }

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblUsuario.Text = dgvCompras[0, dgvCompras.CurrentCell.RowIndex].Value.ToString();
            lblCompra.Text = dgvCompras[1, dgvCompras.CurrentCell.RowIndex].Value.ToString();
            lblIdCompra.Text = dgvCompras[2, dgvCompras.CurrentCell.RowIndex].Value.ToString();

        }
    }
}
