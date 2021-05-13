using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NewWare_Soft.Entidades;

namespace NewWare_Soft.Forms
{
    public partial class ModificarEtapa : Form
    {
        private int pos = 0;
        public ModificarEtapa()
        {
            InitializeComponent();          
        }

        private void ModificarEtapa_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
            CargarGrilla();            
        }


        #region Cargar Grilla
        public void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection canalConexion = new SqlConnection(cadenaConexion)
;
            try
            {
                string query = "select * from etapas";
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                canalConexion.Open();
                cmd.Connection = canalConexion;

                DataTable table = new DataTable();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(table);

                dgvEtapas.DataSource = table;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                canalConexion.Close();
            }
        }
        #endregion

        #region Modificar Etapa
        private bool updateEtapa(Etapas etapa)
        {
            bool isValid = false;
            
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection canalConexion = new SqlConnection(cadenaConexion);

            try
            {
                string query = "update etapas set NombreEtapa = @nombre";
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", etapa.Nombre);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                canalConexion.Open();
                cmd.Connection = canalConexion;
                cmd.ExecuteNonQuery();
                isValid = true;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                canalConexion.Close();
            }
            return isValid;
        }
        #endregion

        private void dgvEtapas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dgvEtapas.Rows[indice];
            string nombre = filaSeleccionada.Cells["NombreEtapa"].Value.ToString();
            txtNombre.Text = nombre;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Etapas etapa = new Etapas();
                etapa.Nombre = txtNombre.Text;
                if (updateEtapa(etapa))
                {
                    CargarGrilla();
                    MessageBox.Show("Operacion exitosa");
                    txtNombre.Text = "";
                    txtNombre.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo ejecutar la operacion");
                    txtNombre.Text = "";
                    txtNombre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
