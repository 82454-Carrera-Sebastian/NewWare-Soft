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
    public partial class Listado_Factura_Cliente : Form
    {
        public Listado_Factura_Cliente()
        {
            InitializeComponent();
        }

        private void Listado_Factura_Cliente_Load(object sender, EventArgs e)
        {

            this.reportViewer_Factura_Cliente.RefreshReport();
        }

        private void reportViewer_Factura_Cliente_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Cliente.ObtenerFacturas_Cliente();

            ReportDataSource ds = new ReportDataSource("DataSet_Fac_Cli", tabla);
            reportViewer_Factura_Cliente.LocalReport.DataSources.Clear();
            reportViewer_Factura_Cliente.LocalReport.DataSources.Add(ds);
            reportViewer_Factura_Cliente.LocalReport.Refresh();

            DataTable tabla2 = new DataTable();
            tabla2 = AD_Cliente.ObtenerDataGrid_tablaEmailCliente();
            ReportDataSource ds2 = new ReportDataSource("DataSet_Cliente", tabla2);
            //reportViewer_Factura_Cliente.LocalReport.DataSources.Clear();
            reportViewer_Factura_Cliente.LocalReport.DataSources.Add(ds2);
            reportViewer_Factura_Cliente.LocalReport.Refresh();
        }
    }
}
