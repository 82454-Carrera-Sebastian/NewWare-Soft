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
    public partial class ListadoProdXFactura : Form
    {
        public ListadoProdXFactura()
        {
            InitializeComponent();
        }

        private void ListadoProdXFactura_Load(object sender, EventArgs e)
        {

            this.rptProducto.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Facturas.ObtenerListadoProductoXFactura();

            ReportDataSource ds = new ReportDataSource("DataSetProductoXFactura", tabla);
            rptProducto.LocalReport.DataSources.Clear();
            rptProducto.LocalReport.DataSources.Add(ds);
            rptProducto.LocalReport.Refresh();

        }
    }
}
