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
    public partial class ModifUser : Form
    {
        public ModifUser()
        {
            InitializeComponent();
        }

        private void ModifUser_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                GrillaUsers.DataSource = AD_Usuarios.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener usuarios");
            }
        }

    }
}
