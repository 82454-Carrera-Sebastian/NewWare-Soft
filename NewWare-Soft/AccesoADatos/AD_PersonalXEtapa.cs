using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewWare_Soft.Entidades;

namespace NewWare_Soft.AccesoADatos
{
    public class AD_PersonalXEtapa
    {
       
        public static DataTable ObtenerPersonalXLegajo(int legajo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM personal WHERE Legajo LIKE @legajo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", legajo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
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
                cn.Close();
            }
        }

        public static bool TransaccionPersonalXEtapa(int idEtapa, int idProyecto, List<Personal>listaPersonal)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlTransaction objTransac = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
               
                

                cn.Open();
                objTransac = cn.BeginTransaction("AltaPersonasXEtapa");
                cmd.Transaction = objTransac;
                cmd.Connection = cn;
                




                foreach (Personal item in listaPersonal)
                {
                    
                    string consulta = "Insert into personal_x_etapas values(@idEtapa, @idProyecto, @legajo, @fechaIngreso, @fechaEgreso, @idCargo, @cantHoras)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idEtapa", idEtapa);
                    cmd.Parameters.AddWithValue("@idProyecto", idProyecto);
                    cmd.Parameters.AddWithValue("@legajo", item.LegajoPersonal);
                    cmd.Parameters.AddWithValue("@fechaIngreso", item.FechaIngresoPersonal);
                    cmd.Parameters.AddWithValue("@FechaEgreso", item.FechaEgresoPersonal);
                    cmd.Parameters.AddWithValue("@idCargo", item.IdCargoPersonal);
                    cmd.Parameters.AddWithValue("@cantHoras", item.CantidadHoras);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;
                    cmd.ExecuteNonQuery();
                }

                objTransac.Commit();

                return true;
            }
            catch (Exception ex)
            {
                objTransac.Rollback();
                throw;
                
            }

            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerEtapas()
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);

            try
            {
                bool res = false;
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM etapas";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

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
                cn.Close();
            }
        }

        public static DataTable ObtenerProyectos()
        {
            string cadenaConn = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConn);

            try
            {
                bool res = false;
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM proyectos";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

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
                cn.Close();
            }
        }
    }
}
