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
    public partial class frmHistorial : Form
    {
        Conexion conn = Conexion.Instance;
        SqlDataAdapter da;

        public frmHistorial()
        {
            InitializeComponent();
            this.getData();
        }

        private void getData(){
            SqlParameter idCalificador = new SqlParameter("@idCalificador", SqlDbType.Int);
            idCalificador.SqlValue = 17; //MOCK
            idCalificador.Direction = ParameterDirection.Input;

            String cmd = "ADIOS_TERCER_ANIO.cargarUltimasCalificaciones";

            da = new SqlDataAdapter(cmd, conn.getConexion);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(idCalificador);
            da.SelectCommand.ExecuteNonQuery();

            DataTable tablaDeCompras = new DataTable("Calificaciones");
            da.Fill(tablaDeCompras);
            dgvHistorial.DataSource = tablaDeCompras;
            dgvHistorial.Columns[0].Width = 100;
            dgvHistorial.Columns[1].Width = 200;
            dgvHistorial.Columns[2].Visible = false;
            dgvHistorial.Columns[3].Width = 200;
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.ReadOnly = true;

            SqlCommand obtenerCantidad = new SqlCommand("ADIOS_TERCER_ANIO.obtenerTipoDeCompraConNPuntaje", conn.getConexion);
            obtenerCantidad.CommandType = System.Data.CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Clear();

            SqlParameter puntaje = new SqlParameter("@puntaje", SqlDbType.Int);
            puntaje.Direction = ParameterDirection.Input;

            SqlParameter tipo = new SqlParameter("@tipo", SqlDbType.NVarChar, 255);
            tipo.Direction = ParameterDirection.Input;

            SqlParameter cantidad = new SqlParameter("@cant", null);
            cantidad.Direction = ParameterDirection.Output;
            cantidad.SqlDbType = SqlDbType.Int;

            puntaje.SqlValue = 1;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblCompras1.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 2;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblCompras2.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 3;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblCompras3.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 4;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblCompras4.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 5;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblCompras5.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 1;
            tipo.SqlValue = "Subasta";

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblSubastas1.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 2;
            
            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblSubastas2.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 3;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblSubastas3.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 4;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblSubastas4.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 5;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblSubastas5.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();
        }
    }
}
