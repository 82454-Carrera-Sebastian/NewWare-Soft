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
            if (txtDenominacion.Text.Equals("") || txtDescripcion.Text.Equals("") || txtFinalizacion.Text.Equals("") || txtPrecio.Text.Equals(""))
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
                        MessageBox.Show("Erro al dar de alta el producto...");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro al dar de alta el producto...");
                }
                
            }
        }
        private void btnBuscarEtapa_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = AD_Productos.obtenerEtapaTabla(txtIdEtapa.Text);
                if (tablaResultado.Rows.Count > 0)
                {
                    txtNombreEtapa.Text = tablaResultado.Rows[0][1].ToString();
                }
                else
                {
                    MessageBox.Show("Etapa no encontrada...");
                    txtIdEtapa.Focus();
                    txtNombreEtapa.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener Etapa...");
            }
        }
        private void btnAgregarEtapa_Click(object sender, EventArgs e)
        {
            if (!existeEnGrilla(txtNombreEtapa.Text))
            {
                grdEtapas.Rows.Add(txtIdEtapa.Text, txtNombreEtapa.Text);
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
    }
}
