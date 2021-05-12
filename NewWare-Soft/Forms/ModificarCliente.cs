using NewWare_Soft.AccesoADatos;
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
    public partial class ModificarCliente : Form
    {
        public ModificarCliente()
        {
            InitializeComponent();
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {
            try
            {
                dataGridView_Clientes.DataSource = AD_Cliente.ObtenerData_grid_Cliente();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR! No se pudo obtener los clientes para modicarlos.");
            }
        }
        private void dataGrid_Cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            button_actualizarCliente.Enabled = true;
            button_LimpiarCampos.Enabled = true;
            DataGridViewRow filaSeleccionada = dataGridView_Clientes.Rows[index];
            string email = filaSeleccionada.Cells["Email"].Value.ToString();
            Cliente dude = AD_Cliente.EncontrarCliente_DB(email);
            LimpiarCampos();
            LlenarCampos(dude);
        }

        private void LlenarCampos(Cliente dude)
        {
            textBox_nombre.Enabled = true;
            textBox_apellido.Enabled = true;
            textBox_barrio.Enabled = true;
            textBox_Email.Enabled = false;
            textBox_nombreCalle.Enabled = true;
            textBox_nroCalle.Enabled = true;
            textBox_telefono.Enabled = true;

            textBox_nombre.Text = dude.Nombre;
            textBox_apellido.Text = dude.Apellido;
            textBox_barrio.Text = dude.Barrio.ToString();
            textBox_Email.Text = dude.Email;
            textBox_nombreCalle.Text = dude.Calle;
            textBox_nroCalle.Text = dude.NroCalle.ToString();
            textBox_telefono.Text = dude.Telefono;
        }

        private void LimpiarCampos()
        {
            textBox_nombre.Text = "";
            textBox_apellido.Text = "";
            textBox_telefono.Text = "";
            textBox_Email.Text = "";
            textBox_barrio.Text = "";
            textBox_nombreCalle.Text = "";
            textBox_nroCalle.Text = "";
        }

        private void button_actualizarCliente_Click(object sender, EventArgs e)
        {
            Cliente mod_Cliente = obtenerData_Cliente();
            bool update = AD_Cliente.UpdateCliente_DB(mod_Cliente);
            if (update)
            {
                MessageBox.Show("El cliente fue actualizado exitosamente.");

                LimpiarCampos();
                LlenarGrilla();
                BloquearTextBoxs();
            }
            else
            {
                MessageBox.Show("ERROR! El cliente no se actualizo correctamente. Vuelva a intentarlo");
            }
        }

        private Cliente obtenerData_Cliente()
        {
            Cliente client = new Cliente();
            client.Nombre = textBox_nombre.Text.Trim();
            client.Apellido = textBox_apellido.Text.Trim();
            client.Telefono = textBox_telefono.Text.Trim();
            client.Email = textBox_Email.Text.Trim();
            textBox_Email.Enabled = false;
            client.Calle = textBox_nombreCalle.Text.Trim();
            client.Barrio = int.Parse(textBox_barrio.Text.Trim());
            client.Telefono = textBox_telefono.Text.Trim();
            client.NroCalle = int.Parse(textBox_nroCalle.Text.Trim());
            return client;
        }
        private void BloquearTextBoxs()
        {
            textBox_nombre.Enabled = false;
            textBox_apellido.Enabled = false;
            textBox_barrio.Enabled = false;
            textBox_Email.Enabled = false;
            textBox_nombreCalle.Enabled = false;
            textBox_nroCalle.Enabled = false;
            textBox_telefono.Enabled = false;
        }

        private void button_LimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
