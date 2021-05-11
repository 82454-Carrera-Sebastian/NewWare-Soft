using NewWare_Soft.Entidades;
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
        public PrincipalForm(Usuarios usu)
        {
            InitializeComponent();
        }

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AltaPersonal ventana = new AltaPersonal();
            ventana.Show();
            this.Hide();
        }

        private void modificacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ModificarPersonal ventana = new ModificarPersonal();
            ventana.Show();
            this.Hide();
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BajaPersonal ventana = new BajaPersonal();
            ventana.Show();
            this.Hide();
        }
    }
}
