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
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
        }
        private void ProductoForm_Load(object sender, EventArgs e)
        {
            limpiarCampos();
            obtenerUltimoIdProducto();
            CargarComboEtapas();
        }
        private void limpiarCampos() 
        {
            txtDenominacion.Text = "";
            txtDescripcion.Text = "";
            txtFinalizacion.Text = "";
            txtPrecio.Text = "";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private Producto obtenerDatosProducto() 
        {
            if (txtDenominacion.Text.Equals("") || txtFinalizacion.Text.Equals("") || txtPrecio.Text.Equals(""))
            {
                return null;
            }
            else
            {
                Producto prod = new Producto();
                prod.Denominacion = txtDenominacion.Text.Trim();
                prod.Descripcion = txtDescripcion.Text.Trim();
                prod.FechaDeFinalizacion = DateTime.Parse(txtFinalizacion.Text);
                prod.Precio = int.Parse(txtPrecio.Text);
                return prod;
            }
            
        }

        private void CargarComboEtapas()
        {
            try
            {
                cmbEtapas.DataSource = AD_Productos.ObtenerEtapa();
                cmbEtapas.DisplayMember = "NombreEtapa";
                cmbEtapas.ValueMember = "IdEtapa";
                cmbEtapas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de etapas");
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto prod = obtenerDatosProducto();
            if (prod == null)
            {
                MessageBox.Show("Primero debe llenar los campos...");
            }
            else
            {
                List<int> listaEtapas = new List<int>();
                for (int i = 0; i < grdEtapas.Rows.Count; i++)
                {
                    listaEtapas.Add(int.Parse(grdEtapas.Rows[i].Cells[0].Value.ToString()));
                }
                try
                {
                    bool resultado = AD_Productos.agregarProductoABd(prod, listaEtapas, int.Parse(txtIdProducto.Text));
                    if (resultado)
                    {
                        MessageBox.Show("Producto dado de alta con exito.");
                        limpiarCampos();
                        obtenerUltimoIdProducto();
                    }
                    else
                    {
                        MessageBox.Show("Error al dar de alta el producto...");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al dar de alta el producto...");
                }
                
            }
        }

        private void btnAgregarEtapa_Click(object sender, EventArgs e)
        {
            int id = AD_Productos.ObtenerIDEtapa(cmbEtapas.Text.Trim());
            if (!existeEnGrilla(cmbEtapas.Text))
            {
                grdEtapas.Rows.Add(id, cmbEtapas.Text);
                btnAgregarProducto.Enabled = true;
            }
            else
            {
                MessageBox.Show("Esta etapa ya se encuntra en la grilla...");
            }
        }
        private bool existeEnGrilla(string aBuscar)
        {
            bool resultado = false;
            for (int i = 0; i < grdEtapas.Rows.Count; i++)
            {
                if (grdEtapas.Rows[i].Cells["nombre"].Value.Equals(aBuscar))
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }
        private void obtenerUltimoIdProducto()
        {
            int id = AD_Productos.obtenerUltimoProductoId();
            txtIdProducto.Text = (id + 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proyectos ventana = new Proyectos();
            ventana.ShowDialog();
        }
    }
}
