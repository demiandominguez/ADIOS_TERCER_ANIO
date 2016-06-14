﻿using MercadoEnvios.ABM_Usuario;
using MercadoEnvios.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.Generar_Publicación
{
    public partial class frmGenerarPublicacion : Form
    {
        Conexion conn;
        Sesion sesion;
        Utilidades funcion = new Utilidades();
        StringBuilder mensajeValidacion = new StringBuilder();
        public frmGenerarPublicacion()
        {
            InitializeComponent();
            sesion = Sesion.Instance;
            this.conn = Conexion.Instance;
            this.loadGrid();
        }

        private void loadGrid()
        {
            string rubrosDisponibles = "SELECT r.descripcionCorta FROM ADIOS_TERCER_ANIO.Rubro r";
            conn = Conexion.Instance;
            SqlCommand buscarRubrosDisponibles = new SqlCommand(rubrosDisponibles, conn.getConexion);
            SqlDataReader dabuscarRubrosDisponibles = buscarRubrosDisponibles.ExecuteReader();

            while (dabuscarRubrosDisponibles.Read())
            {
                rubros.Items.Add(dabuscarRubrosDisponibles.GetString(0));
            }
            dabuscarRubrosDisponibles.Close();

            string queryVisibilidad = "SELECT descripcion FROM ADIOS_TERCER_ANIO.Visibilidad";
            SqlCommand buscarVisibilidades = new SqlCommand(queryVisibilidad, conn.getConexion);
            SqlDataReader dataReader = buscarVisibilidades.ExecuteReader();
            while (dataReader.Read())
            {
                visibilidad.Items.Add(dataReader.GetString(0));
            }

            dataReader.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            funcion.validarComboVacio(visibilidad, mensajeValidacion);
            funcion.validarComboVacio(tipoDePublicacion, mensajeValidacion);
            funcion.validarComboVacio(rubros, mensajeValidacion);
            funcion.validarNoVacio(descripcion, mensajeValidacion);
            funcion.validarNoVacio(precio, mensajeValidacion);

            bool validaciones;

            if (mensajeValidacion.Length > 0)
            {
                validaciones = false;
                MessageBox.Show(mensajeValidacion.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mensajeValidacion = new StringBuilder();

            }
            else
            {validaciones = true;}

            if (validaciones)
            {
                SqlCommand generarPublicacion = new SqlCommand("ADIOS_TERCER_ANIO.AgregarPublicacion", conn.getConexion);
                generarPublicacion.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter descripcionP = new SqlParameter("@descripcion", SqlDbType.NVarChar, 255);
                descripcionP.SqlValue = descripcion.Text;
                descripcionP.Direction = ParameterDirection.Input;

                SqlParameter precioP = new SqlParameter("@precio", SqlDbType.Decimal);
                precioP.SqlValue = Convert.ToDecimal(precio.Text);
                precioP.Direction = ParameterDirection.Input;

                SqlParameter stockP = new SqlParameter("@stock", SqlDbType.Int);
                stockP.SqlValue = Convert.ToInt32(stock.Value);
                stockP.Direction = ParameterDirection.Input;

                SqlParameter visibilidadP = new SqlParameter("@visibilidad", SqlDbType.NVarChar, 255);
                visibilidadP.SqlValue = visibilidad.Text;
                visibilidadP.Direction = ParameterDirection.Input;

                SqlParameter tipoDePublicacionP = new SqlParameter("@tipo", SqlDbType.NVarChar, 255);
                tipoDePublicacionP.SqlValue = tipoDePublicacion.Text;
                tipoDePublicacionP.Direction = ParameterDirection.Input;

                SqlParameter rubro = new SqlParameter("@rubro", SqlDbType.NVarChar, 255);
                rubro.SqlValue = rubros.Text;
                rubro.Direction = ParameterDirection.Input;

                SqlParameter habilitaPreguntas = new SqlParameter("@tienePreguntas", SqlDbType.Int);
                if (habilitarEnvios.Checked)
                {
                    habilitaPreguntas.SqlValue = 0;
                }
                else
                {
                    habilitaPreguntas.SqlValue = 1;
                }
                habilitaPreguntas.Direction = ParameterDirection.Input;

                SqlParameter fechaInicio = new SqlParameter("@fechaInicio", SqlDbType.DateTime);
                fechaInicio.SqlValue = DBNull.Value;
                fechaInicio.Direction = ParameterDirection.Input;

                SqlParameter fechaFin = new SqlParameter("@fechaFin", SqlDbType.DateTime);
                fechaFin.SqlValue = DBNull.Value;
                fechaFin.Direction = ParameterDirection.Input;

                SqlParameter estadoP = new SqlParameter("@estado", SqlDbType.NVarChar, 255);
                estadoP.SqlValue = "Borrador";
                estadoP.Direction = ParameterDirection.Input;

                SqlParameter idP = new SqlParameter("@idPublicador", SqlDbType.Int);
                idP.SqlValue = sesion.idUsuario;
                idP.Direction = ParameterDirection.Input;

                SqlParameter envio = new SqlParameter("@envio", SqlDbType.Int);

                if (habilitarEnvios.Checked)
                {
                    envio.SqlValue = 0;
                }
                else
                {
                    envio.SqlValue = 1;
                }
                envio.Direction = ParameterDirection.Input;


                generarPublicacion.Parameters.Add(descripcionP);

                generarPublicacion.Parameters.Add(precioP);
                generarPublicacion.Parameters.Add(stockP);
                generarPublicacion.Parameters.Add(visibilidadP);
                generarPublicacion.Parameters.Add(tipoDePublicacionP);
                generarPublicacion.Parameters.Add(rubro);
                generarPublicacion.Parameters.Add(habilitaPreguntas);
                generarPublicacion.Parameters.Add(fechaInicio);
                generarPublicacion.Parameters.Add(fechaFin);
                generarPublicacion.Parameters.Add(estadoP);
                generarPublicacion.Parameters.Add(idP);
                generarPublicacion.Parameters.Add(envio);
                generarPublicacion.ExecuteNonQuery();

                new frmElegirAccion().Show();
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmElegirAccion().Show();
            this.Close();
        }
    }


}
