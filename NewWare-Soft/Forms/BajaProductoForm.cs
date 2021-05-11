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
    public partial class BajaProductoForm : Form
    {
        public BajaProductoForm()
        {
            InitializeComponent();
        }

        private void BajaProductoForm_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            limpiarCampos();
            btnEliminarProducto.Enabled = false;
            txtDescripcion.Enabled = false;
            txtFinalizacion.Enabled = false;
            txtPrecio.Enabled = false;
            txtDenominacion.Enabled = false;
        }
        private void cargarGrilla()
        {
            try
            {
                grdProductos.DataSource = AD_Productos.cargarGrilla();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los productos");
            }
        }
        private void limpiarCampos()
        {
            txtDenominacion.Text = "";
            txtDescripcion.Text = "";
            txtFinalizacion.Text = "";
            txtPrecio.Text = "";
        }

        private void grdProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grdProductos.Rows[indice];
            string denominacion = filaSeleccionada.Cells["denominacion"].Value.ToString();
            Producto prod = AD_Productos.obtenerProducto(denominacion);
            limpiarCampos();
            cargarCampos(prod);
        }
        private void cargarCampos(Producto prod)
        {
            txtDenominacion.Text = prod.Denominacion;
            txtDescripcion.Text = prod.Descripcion;
            DateTime fecha = prod.FechaDeFinalizacion;
            string dia;
            string mes;
            string año;
            dia = fecha.Date.Day.ToString();
            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }
            mes = fecha.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            año = fecha.Date.Year.ToString();
            txtFinalizacion.Text = dia + mes + año;
            txtPrecio.Text = prod.Precio.ToString();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Producto prod = obtenerProducto();
            bool resultado = AD_Productos.eliminarProducto(prod);
            if (resultado)
            {
                MessageBox.Show("Se actualizo el producto con exito!");
                limpiarCampos();
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al actualizar el producto");
            }
        }
        private Producto obtenerProducto()
        {
            Producto prod = new Producto();
            prod.Denominacion = txtDenominacion.Text.Trim();
            prod.Descripcion = txtDescripcion.Text.Trim();
            prod.FechaDeFinalizacion = DateTime.Parse(txtFinalizacion.Text);
            prod.Precio = int.Parse(txtPrecio.Text);
            return prod;
        }
    }
}
