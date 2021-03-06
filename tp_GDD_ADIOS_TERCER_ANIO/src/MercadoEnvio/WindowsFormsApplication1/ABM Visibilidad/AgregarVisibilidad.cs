﻿using MercadoEnvios.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.ABM_Visibilidad
{
    public partial class frmAgregarVisibilidad : Form
    {
        Conexion conn;
        StringBuilder mensajeValidacion = new StringBuilder();
        Utilidades fun = new Utilidades();

        public frmAgregarVisibilidad()
        {
            conn = Conexion.Instance;
            InitializeComponent();
        }

        public void salir()
        {
            new ABM_Visibilidad.frmABMVisibilidad().Show();
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
                this.fun.validarVisibilidad(Nombre, mensajeValidacion);
                this.fun.validarNoVacio(Nombre, mensajeValidacion);
                this.fun.validarNoVacio(Duracion, mensajeValidacion);
                bool porc = this.fun.validarNoVacio(Porcentaje, mensajeValidacion);
                this.fun.validarNoVacio(Precio, mensajeValidacion);
                this.fun.validarDecimal(Precio, mensajeValidacion);
                bool num = this.fun.validarDecimal(Porcentaje, mensajeValidacion);

                if (porc && num)
                {
                    this.fun.validarPorcentaje(Porcentaje, mensajeValidacion);
                }

                if (mensajeValidacion.Length == 0)
                {
                    SqlCommand agregarVisibilidad = new SqlCommand("ADIOS_TERCER_ANIO.AgregarVisibilidad", conn.getConexion);
                    agregarVisibilidad.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.NVarChar, 255);
                    if (string.IsNullOrEmpty(Nombre.Text))
                    {
                        nombre.SqlValue = DBNull.Value;
                    }
                    else
                    {
                        nombre.SqlValue = Nombre.Text;
                    }
                    nombre.Direction = ParameterDirection.Input;

                    SqlParameter duracion = new SqlParameter("@duracion", SqlDbType.Int);
                    if (string.IsNullOrEmpty(Duracion.Text))
                    {
                        duracion.SqlValue = DBNull.Value;
                    }
                    else
                    {
                        duracion.SqlValue = Convert.ToInt32(Duracion.Text);
                    }
                    duracion.Direction = ParameterDirection.Input;

                    SqlParameter precio = new SqlParameter("@precio", SqlDbType.Decimal);
                    if (string.IsNullOrEmpty(Precio.Text))
                    {
                        precio.SqlValue = DBNull.Value;
                    }
                    else
                    {
                        precio.SqlValue = Convert.ToDecimal(Precio.Text);
                    }
                    precio.Direction = ParameterDirection.Input;

                    SqlParameter porcentaje = new SqlParameter("@porcentaje", SqlDbType.Decimal);
                    if (string.IsNullOrEmpty(Porcentaje.Text))
                    {
                        porcentaje.SqlValue = DBNull.Value;
                    }
                    else
                    {
                        porcentaje.SqlValue = Convert.ToDecimal(Porcentaje.Text);
                    }
                    porcentaje.Direction = ParameterDirection.Input;

                    agregarVisibilidad.Parameters.Add(nombre);
                    agregarVisibilidad.Parameters.Add(duracion);
                    agregarVisibilidad.Parameters.Add(precio);
                    agregarVisibilidad.Parameters.Add(porcentaje);

                    try
                    {
                        agregarVisibilidad.ExecuteNonQuery();
                        this.salir();
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                else
                {
                     MessageBox.Show(mensajeValidacion.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mensajeValidacion = new StringBuilder();
                }
            }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.salir();
        }

        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.ingresarNumero(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.ingresarNumeroDecimal(e);
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.ingresarNumeroDecimal(e);
        }
    }
}
