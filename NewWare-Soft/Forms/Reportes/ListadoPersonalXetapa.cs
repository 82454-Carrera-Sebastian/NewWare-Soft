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
    public partial class ListadoPersonalXetapa : Form
    {
        public ListadoPersonalXetapa()
        {
            InitializeComponent();
        }

        private void ListadoPersonalXetapa_Load(object sender, EventArgs e)
        {

            this.reportViewerPersonalXetapa.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_PersonalXEtapa.ObtenerListadoPersonalXetapa();

            ReportDataSource ds = new ReportDataSource("DataSet_PersonalXetapa", tabla);
            reportViewerPersonalXetapa.LocalReport.DataSources.Clear();
            reportViewerPersonalXetapa.LocalReport.DataSources.Add(ds);
            reportViewerPersonalXetapa.LocalReport.Refresh();
        }
    }
}
