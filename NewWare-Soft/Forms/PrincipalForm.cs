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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Alta Producto
            ProductoForm ventana = new ProductoForm();
            ventana.Show();
        }

        private void modificacionToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Modificacion Producto
            ModificacionProductoForm ventana = new ModificacionProductoForm();
            ventana.Show();
        }

        private void bajaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Baja Producto
            BajaProductoForm ventana = new BajaProductoForm();
            ventana.Show();
        }
    }
}
