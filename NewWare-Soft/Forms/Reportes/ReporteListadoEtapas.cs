using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft.Forms.Reportes
{
    public partial class ReporteListadoEtapas : Form
    {
        public ReporteListadoEtapas()
        {
            InitializeComponent();
        }

        private void ReporteListadoEtapas_Load(object sender, EventArgs e)
        {

            this.ReportListEtapas.RefreshReport();
        }

        private void ReportListEtapas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = ObtenerListadoEtapas();

            ReportDataSource ds = new ReportDataSource("Datos_Etapas", tabla);
            ReportListEtapas.LocalReport.DataSources.Clear();
            ReportListEtapas.LocalReport.DataSources.Add(ds);
            ReportListEtapas.LocalReport.Refresh();

        }



        public static DataTable ObtenerListadoEtapas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
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
    }
}
