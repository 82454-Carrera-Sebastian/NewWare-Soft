using NewWare_Soft.Entidades;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWare_Soft.AccesoADatos
{
    class AD_Productos
    {
        public static bool agregarProductoABd(Producto prod, List<int> listaEtapas, int idProducto)
        {
            bool resultado = false;
            try
            {
                Producto existe = obtenerProducto(prod.Denominacion);
                if (existe == null)
                {
                    string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                    SqlTransaction objTransaccion = null;
                    SqlConnection connect = new SqlConnection(cadenaConexion);
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        string consulta = "INSERT INTO productos (Denominacion, Descripcion, FechaFinalizacion, PrecioVenta) VALUES (@denominacion, @descripcion, @fechaFinalizacion, @precioVenta)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@denominacion", prod.Denominacion);
                        cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                        cmd.Parameters.AddWithValue("@fechaFinalizacion", prod.FechaDeFinalizacion);
                        cmd.Parameters.AddWithValue("@precioVenta", prod.Precio);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = consulta;
                        connect.Open();
                        objTransaccion = connect.BeginTransaction("AltaDeEtapas");
                        cmd.Transaction = objTransaccion;
                        cmd.Connection = connect;
                        cmd.ExecuteNonQuery();
                        foreach (var etapa in listaEtapas)
                        {
                            string consulta2 = "INSERT INTO etapas_x_producto VALUES (@IdEtapa, @IdProducto)";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@IdEtapa", etapa);
                            cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                            cmd.CommandText = consulta2;
                            cmd.ExecuteNonQuery();
                        }
                        objTransaccion.Commit();
                        resultado = true;
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
        public static int obtenerUltimoProductoId()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT MAX(IdProducto) FROM productos";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                connect.Open();
                cmd.Connection = connect;
                int resultado = (int)cmd.ExecuteScalar();
                return resultado;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                connect.Close();
            }
        }
        public static Producto obtenerProducto(string denominacion)
        {
            Producto prod = new Producto();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM productos WHERE Denominacion LIKE @denominacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@denominacion", denominacion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                connect.Open();
                cmd.Connection = connect;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    prod.Denominacion = dr["Denominacion"].ToString();
                    prod.Descripcion = dr["Descripcion"].ToString();
                    prod.FechaDeFinalizacion = DateTime.Parse(dr["FechaFinalizacion"].ToString());
                    prod.Precio = int.Parse(dr["PrecioVenta"].ToString());
                }
                else
                {
                    prod = null;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
            return prod;
        }
        public static DataTable cargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT Denominacion, Descripcion, FechaFinalizacion, PrecioVenta FROM productos";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                connect.Open();
                cmd.Connection = connect;
                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
        }
        public static bool actualizarProducto(Producto prod)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE productos SET Denominacion = @denominacion, Descripcion = @descripcion, FechaFinalizacion = @fechaFinalizacion, PrecioVenta = @precio WHERE Denominacion LIKE @denominacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@denominacion", prod.Denominacion);
                cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                cmd.Parameters.AddWithValue("@fechaFinalizacion", prod.FechaDeFinalizacion);
                cmd.Parameters.AddWithValue("@precio", prod.Precio);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                connect.Open();
                cmd.Connection = connect;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
            return resultado;
        }
        public static bool eliminarProducto(Producto prod)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM productos WHERE Denominacion LIKE @denominacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@denominacion", prod.Denominacion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                connect.Open();
                cmd.Connection = connect;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
            return resultado;
        }
        public static DataTable obtenerEtapaTabla(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection connect = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM etapas WHERE IdEtapa LIKE @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                connect.Open();
                cmd.Connection = connect;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
        }
    }
}