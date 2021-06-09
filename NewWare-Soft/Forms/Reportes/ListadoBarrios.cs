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
    public partial class ListadoBarrios : Form
    {
        public ListadoBarrios()
        {
            InitializeComponent();
        }

        private void ListadoBarrios_Load(object sender, EventArgs e)
        {

            this.reporte_barrios.RefreshReport();
        }

        private void reporte_barrios_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Barrios.obtenerDatosBarrios();

            ReportDataSource ds = new ReportDataSource("DatosBarrios", tabla);

            reporte_barrios.LocalReport.DataSources.Clear();
            reporte_barrios.LocalReport.DataSources.Add(ds);
            reporte_barrios.LocalReport.Refresh();
        }
    }
}
