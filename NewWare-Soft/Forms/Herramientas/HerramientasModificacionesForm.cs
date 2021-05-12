using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft.Forms.Herramientas
{
    public partial class HerramientasModificacionesForm : Form
    {
        public HerramientasModificacionesForm()
        {
            InitializeComponent();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnModificarHerramienta_Click(object sender, EventArgs e)
        {

        }
    }
}
