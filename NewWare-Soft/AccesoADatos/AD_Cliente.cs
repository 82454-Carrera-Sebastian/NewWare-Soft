﻿using NewWare_Soft.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.AccesoADatos
{
    class AD_Cliente
    {
        public static bool AgregarCliente_DB(Cliente client)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                bool result = false;
                string query = "InsertarNuevoCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", client.Nombre);
                cmd.Parameters.AddWithValue("@apellido", client.Apellido);
                cmd.Parameters.AddWithValue("@telefono", client.Telefono);
                cmd.Parameters.AddWithValue("@email", client.Email);
                cmd.Parameters.AddWithValue("@nroCalle", client.NroCalle);
                cmd.Parameters.AddWithValue("@calle", client.Calle);
                cmd.Parameters.AddWithValue("@idBarrio", client.Barrio);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerData_grid_Cliente()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT Email, Apellido, Nombre FROM clientes";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;


                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static Boolean BorrarCliente_DB(string var)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "BorrarCliente2";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@email", var);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;

                cn.Open();
                cmd.Connection = cn;
                return true;
            }

            catch (Exception)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }

        }

        public static Cliente EncontrarCliente_DB(string email)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente dude = new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "EncontrarCliente_Email";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@email", email);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    dude.Nombre = dr["Nombre"].ToString();
                    dude.Apellido = dr["Apellido"].ToString();
                    dude.Telefono = dr["Telefono"].ToString();
                    dude.Email = dr["Email"].ToString();
                    dude.NroCalle = int.Parse(dr["NroCalle"].ToString());
                    dude.Calle = dr["Calle"].ToString();
                    dude.Barrio = int.Parse(dr["IdBarrio"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return dude;
        }
        public static Boolean EncontrarCliente_Bool_DB(string email)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente dude = new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "EncontrarCliente_Email";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@email", email);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }


        public static bool UpdateCliente_DB(Cliente mod_cliente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                result = false;
                string query = "UPDATE clientes SET Nombre = @nombre, Apellido = @apellido, Email = @email, Telefono = @telefono, NroCalle = @nroCalle, Calle = @nombreCalle, IdBarrio = @idBarrio WHERE Email like @email";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", mod_cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", mod_cliente.Apellido);
                cmd.Parameters.AddWithValue("@email", mod_cliente.Email);
                cmd.Parameters.AddWithValue("@telefono", mod_cliente.Telefono);
                cmd.Parameters.AddWithValue("@nroCalle", mod_cliente.NroCalle);
                cmd.Parameters.AddWithValue("@nombreCalle", mod_cliente.Calle);
                cmd.Parameters.AddWithValue("@idBarrio", mod_cliente.Barrio);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

