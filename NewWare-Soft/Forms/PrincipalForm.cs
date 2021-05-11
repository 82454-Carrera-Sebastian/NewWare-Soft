﻿using NewWare_Soft.Entidades;
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

        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Alta Producto
            ProductoForm ventana = new ProductoForm();
            ventana.Show();
        }


        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm ventana = new UserForm();
            ventana.Show();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifUser ventana = new ModifUser();
            ventana.Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElimUser ventana = new ElimUser();
            ventana.Show();
        }

        private void bajaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BajaProductoForm ventana = new BajaProductoForm();
            ventana.Show();
        }

        private void modificacionToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ModificacionProductoForm ventana = new ModificacionProductoForm();
            ventana.Show();
        }
    }
}
