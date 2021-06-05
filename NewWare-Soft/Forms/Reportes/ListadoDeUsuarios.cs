using Microsoft.Reporting.WinForms;
using NewWare_Soft.AccesoADatos_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft.Forms
{
    public partial class ListadoDeUsuarios : Form
    {
        public ListadoDeUsuarios()
        {
            InitializeComponent();
        }

        private void ListadoDeUsuarios_Load(object sender, EventArgs e)
        {
            this.reportUsuarios.RefreshReport();
        }

        private void reportUsuarios_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Usuarios.ObtenerUsuarios();

            ReportDataSource ds = new ReportDataSource("DatosUsuarios", tabla);
            reportUsuarios.LocalReport.DataSources.Clear();
            reportUsuarios.LocalReport.DataSources.Add(ds);
            reportUsuarios.LocalReport.Refresh();
        }
    }
}
