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
    public partial class ListadoFormasDePago : Form
    {
        public ListadoFormasDePago()
        {
            InitializeComponent();
        }

        private void ListadoFormasDePago_Load(object sender, EventArgs e)
        {

            this.report_FormasdePago.RefreshReport();
        }

        private void report_FormasdePago_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_FPago.ObtenerTiposPago();

            ReportDataSource ds = new ReportDataSource("DatosFormaDePago", tabla);

            report_FormasdePago.LocalReport.DataSources.Clear();
            report_FormasdePago.LocalReport.DataSources.Add(ds);
            report_FormasdePago.LocalReport.Refresh();

        }
    }
}
