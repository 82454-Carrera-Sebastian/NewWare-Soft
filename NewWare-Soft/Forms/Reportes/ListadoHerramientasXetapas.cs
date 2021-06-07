using System;
using NewWare_Soft.AccesoADatos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace NewWare_Soft.Forms.Reportes
{
    public partial class ListadoHerramientasXetapas : Form
    {
        public ListadoHerramientasXetapas()
        {
            InitializeComponent();
        }

        private void ListadoHerramientasXetapas_Load(object sender, EventArgs e)
        {

            this.reportViewerHerramientasXetapas.RefreshReport();
        }

        private void reportViewerHerramientasXetapas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Herramientas.ObtenerListadoHerramientaXetapa();

            ReportDataSource ds = new ReportDataSource("DatosHerramientasXetapa", tabla);
            reportViewerHerramientasXetapas.LocalReport.DataSources.Clear();
            reportViewerHerramientasXetapas.LocalReport.DataSources.Add(ds);
            reportViewerHerramientasXetapas.LocalReport.Refresh();
        }
    }
}
