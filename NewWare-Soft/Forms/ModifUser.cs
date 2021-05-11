using NewWare_Soft.AccesoADatos_Usuarios;
using NewWare_Soft.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtNewUser2.Clear();
            txtNewPass2.Clear();
            txtConfirmPass2.Clear();
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

        private Usuarios ObtenerUsuario(string User) //
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Usuarios U = new Usuarios();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM usuarios where NombreUsuario LIKE @user";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@user", User);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    U.NombreUsuario = dr["NombreUsuario"].ToString();
                    U.Password = dr["Password"].ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return U;
        }

        private Usuarios ObtenerDatosUsuario()
        {
            Usuarios U = new Usuarios();
            U.NombreUsuario = txtNewUser2.Text.Trim(); 
            U.Password = txtNewPass2.Text;
            return U;
        }

            private void GrillaUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            DataGridViewRow filaselec = GrillaUsers.Rows[indice];
            string user = filaselec.Cells["User"].Value.ToString(); //
            Usuarios U = ObtenerUsuario(user);
            LimpiarCampos();
            CargarCampos(U);

        }

        private void CargarCampos(Usuarios U)
        {
            txtNewUser2.Text = U.NombreUsuario;
            txtNewPass2.Text = U.Password;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNewUser2.Text.Equals("") || AD_Usuarios.ValidarUsuario(txtNewUser2.Text, txtNewPass2.Text))
            {
                MessageBox.Show("No rellenó el nombre de usuario o escogió uno ya utilizado previamente");
                LimpiarCampos();
                txtNewUser2.Focus();
            }
            else
            {
                if (txtNewPass2.Text.Equals(txtConfirmPass2.Text))
                {
                    try
                    {
                        Usuarios U = ObtenerDatosUsuario();
                        bool resultado = ModificarUsuario(U);
                        if (resultado)
                        {
                            MessageBox.Show("Usuario modificado con éxito");
                            LimpiarCampos();
                            CargarGrilla();
                            btnModificar.Enabled = false;
                            btnEliminar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar el usuario");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar usuario");
                        txtNewUser2.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        }

        private bool ModificarUsuario(Usuarios usu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE usuarios SET Password = @pass WHERE NombreUsuario like @nombre" ; //
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", usu.NombreUsuario);
                cmd.Parameters.AddWithValue("@pass", usu.Password);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        private bool EliminarUsuario(Usuarios usu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM usuarios WHERE NombreUsuario like @nombre"; //
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", usu.NombreUsuario);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios U = ObtenerDatosUsuario();
                bool resultado = EliminarUsuario(U);
                if (resultado)
                {
                    MessageBox.Show("Usuario eliminado con éxito");
                    LimpiarCampos();
                    CargarGrilla();
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al eliminar el usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario");
                txtNewUser2.Focus();
            }
        }
    }

}
