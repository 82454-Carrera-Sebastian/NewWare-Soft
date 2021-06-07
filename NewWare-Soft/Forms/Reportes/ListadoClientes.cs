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
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();
        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {

            this.reportViewer_Clientes.RefreshReport();
        }

        private void reportViewer_Clientes_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Cliente.ObtenerDataGrid_Cliente();

            ReportDataSource ds = new ReportDataSource("DataSet_Cliente",tabla);
            reportViewer_Clientes.LocalReport.DataSources.Clear();
            reportViewer_Clientes.LocalReport.DataSources.Add(ds);
            reportViewer_Clientes.LocalReport.Refresh();
        }
    }
}
