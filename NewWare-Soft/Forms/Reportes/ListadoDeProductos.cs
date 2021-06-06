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
    public partial class ListadoDeProductos : Form
    {
        public ListadoDeProductos()
        {
            InitializeComponent();
        }
        private void ListadoDeProductos_Load(object sender, EventArgs e)
        {
            this.listadoProductos.RefreshReport();
        }
        private void listadoProductos_Load(object sender, EventArgs e)
        {
            DataTable tabla = AD_Productos.obtenerListadoProductos();
            ReportDataSource ds = new ReportDataSource("DatosProductos", tabla);
            listadoProductos.LocalReport.DataSources.Clear();
            listadoProductos.LocalReport.DataSources.Add(ds);
            listadoProductos.LocalReport.Refresh();
        }
    }
}
