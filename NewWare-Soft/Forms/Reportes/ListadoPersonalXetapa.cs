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
            CargarTipoReporte();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbTipoReporte.Text.Equals("Todos los reportes"))
            {
                DataTable tabla = new DataTable();
                tabla = AD_PersonalXEtapa.ObtenerListadoPersonalXetapa();

                ReportDataSource ds = new ReportDataSource("DataSet_PersonalXetapa", tabla);
                reportViewerPersonalXetapa.LocalReport.DataSources.Clear();
                reportViewerPersonalXetapa.LocalReport.DataSources.Add(ds);
                reportViewerPersonalXetapa.LocalReport.Refresh();
            }


        }

        private void button_Siguiente_Click(object sender, EventArgs e)
        {
            LimpiarIconos();
        }
        private void CargarTipoReporte()
        {
            DataTable tablaTipoReportes = new DataTable();
            tablaTipoReportes.Columns.Add("Tipo de reporte");
            tablaTipoReportes.Rows.Add("Todos los reportes");
            tablaTipoReportes.Rows.Add("Buscar por Id de Etapa");
            tablaTipoReportes.Rows.Add("Buscar por Id de Proyecto");
            tablaTipoReportes.Rows.Add("Buscar por Id de Cargo");
            tablaTipoReportes.Rows.Add("Buscar por rango de fecha");
            tablaTipoReportes.Rows.Add("Buscar por Legajo");

            cmbTipoReporte.DataSource = tablaTipoReportes;
            cmbTipoReporte.DisplayMember = "Tipo de reporte";
        }

        private void LimpiarIconos()
        {

        }

    }
}
