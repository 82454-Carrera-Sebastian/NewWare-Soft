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
    public partial class ListadoDeTodosLosProyectos : Form
    {
        public ListadoDeTodosLosProyectos()
        {
            InitializeComponent();
        }

        private void ListadoDeTodosLosProyectos_Load(object sender, EventArgs e)
        {

            this.reportProyectos.RefreshReport();
        }

        private void reportProyectos_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Proyectos.ObtenerProyectos();

            ReportDataSource ds = new ReportDataSource("DatosProyectos", tabla);
            reportProyectos.LocalReport.DataSources.Clear();
            reportProyectos.LocalReport.DataSources.Add(ds);
            reportProyectos.LocalReport.Refresh();
        }
    }
}
