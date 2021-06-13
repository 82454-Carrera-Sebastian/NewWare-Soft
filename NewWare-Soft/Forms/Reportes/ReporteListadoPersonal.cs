using Microsoft.Reporting.WinForms;
using NewWare_Soft.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft.Forms.Reportes
{
    public partial class ReporteListadoPersonal : Form
    {
        public ReporteListadoPersonal()
        {
            InitializeComponent();
        }

        private void ReporteListadoPersonal_Load(object sender, EventArgs e)
        {

            this.ReportListPersonal.RefreshReport();
        }

        private void ReportListPersonal_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = DAOpersonal.ObtenerListadoPersonalpReporte();

            ReportDataSource ds = new ReportDataSource("Datos_Personal", tabla);
            ReportListPersonal.LocalReport.DataSources.Clear();
            ReportListPersonal.LocalReport.DataSources.Add(ds);
            ReportListPersonal.LocalReport.Refresh();
        }
    }
}
