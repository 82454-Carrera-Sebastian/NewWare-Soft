using NewWare_Soft.Entidades;
using NewWare_Soft.Forms.Herramientas;
using NewWare_Soft.Forms.Reportes;
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

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm ventana = new UserForm();
            ventana.ShowDialog();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifUser ventana = new ModifUser();
            ventana.ShowDialog();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElimUser ventana = new ElimUser();
            ventana.ShowDialog();
        }

        private void bajaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BajaProductoForm ventana = new BajaProductoForm();
            ventana.ShowDialog();
        }

        private void modificacionToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ModificacionProductoForm ventana = new ModificacionProductoForm();
            ventana.Show();
        }

        private void altaToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            ProductoForm ventana = new ProductoForm();
            ventana.ShowDialog();
        }
        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AltaPersonal ventana = new AltaPersonal();
            ventana.ShowDialog();
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BajaPersonal ventana = new BajaPersonal();
            ventana.ShowDialog();
        }

        private void modificacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ModificarPersonal ventana = new ModificarPersonal();
            ventana.ShowDialog();
        }


        private void bajaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            HerramientasBajasForm ventana = new HerramientasBajasForm();
            ventana.ShowDialog();
        }

        private void altaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            HerramientasAltasForm ventana = new HerramientasAltasForm();
            ventana.ShowDialog();
        }

        private void modificacionToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            HerramientasModificacionesForm ventana = new HerramientasModificacionesForm();
            ventana.ShowDialog();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaCliente window = new AltaCliente();
            window.ShowDialog();
        }

        private void bajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BajaCliente window = new BajaCliente();
            window.ShowDialog();
        }

        private void modificacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificarCliente window = new ModificarCliente();
            window.ShowDialog();
        }

        private void altaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            AltaEtapa ventana = new AltaEtapa();
            ventana.ShowDialog();
        }

        private void bajaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            BajaEtapa ventana = new BajaEtapa();
            ventana.ShowDialog();
        }

        private void modificacionToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ModificarEtapa ventana = new ModificarEtapa();
            ventana.ShowDialog();
        }

        private void altaToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Alta_Cargo ventana = new Alta_Cargo();
            ventana.ShowDialog();
        }

        private void bajaToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Baja_Cargo ventana = new Baja_Cargo();
            ventana.ShowDialog();
        }

        private void modificacionToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Modificacion_Cargo ventana = new Modificacion_Cargo();
            ventana.ShowDialog();
        }

        private void altaToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Alta_Tarjeta ventana = new Alta_Tarjeta();
            ventana.ShowDialog();
        }

        private void bajaToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Baja_Tarjeta ventana = new Baja_Tarjeta();
            ventana.ShowDialog();
        }

        private void modificacionToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Mod_Tarjeta ventana = new Mod_Tarjeta();
            ventana.ShowDialog();
        }

        private void altaToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Alta_Banco ventana = new Alta_Banco();
            ventana.ShowDialog();
        }

        private void bajaToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Baja_Banco ventana = new Baja_Banco();
            ventana.ShowDialog();
        }

        private void modificacionToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Mod_Banco ventana = new Mod_Banco();
            ventana.ShowDialog();
        }

        private void altaToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Alta_MotivoEgreso ventana = new Alta_MotivoEgreso();
            ventana.ShowDialog();
        }

        private void bajaToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Baja_MotivoEgreso ventana = new Baja_MotivoEgreso();
            ventana.ShowDialog();
        }

        private void modificacionToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Mod_MotivoEgreso ventana = new Mod_MotivoEgreso();
            ventana.ShowDialog();
        }

        private void altaToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Alta_FormPago ventana = new Alta_FormPago();
            ventana.ShowDialog();
        }

        private void bajaToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Baja_FormPago ventana = new Baja_FormPago();
            ventana.ShowDialog();
        }

        private void modificacionToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Mod_FormPago ventana = new Mod_FormPago();
            ventana.ShowDialog();
        }

        private void altaToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            AltaCiudad ventana = new AltaCiudad();
            ventana.ShowDialog();
        }

        private void bajaToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            BajaCiudad ventana = new BajaCiudad();
            ventana.ShowDialog();
        }

        private void modificacionToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ModificacionCiudad ventana = new ModificacionCiudad();
            ventana.ShowDialog();
        }

        private void altaToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            AltaBarrio ventana = new AltaBarrio();
            ventana.ShowDialog();
        }

        private void bajaToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            BajaBarrio ventana = new BajaBarrio();
            ventana.ShowDialog();
        }

        private void modificacionToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            ModificacionBarrio ventana = new ModificacionBarrio();
            ventana.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea salir?", "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void formaDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaFormaPago ventana = new AltaFormaPago();
            ventana.ShowDialog();
        }

        private void btnNewProj_Click(object sender, EventArgs e)
        {
            Proyectos ventana = new Proyectos();
            ventana.ShowDialog();
        }

        private void btnAsignPersonal_Click(object sender, EventArgs e)
        {
            PersonalXEtapa ventana = new PersonalXEtapa();
            ventana.ShowDialog();
        }

        private void btnAsignHerramientas_Click(object sender, EventArgs e)
        {
            HerramientasPorEtapa ventana = new HerramientasPorEtapa();
            ventana.ShowDialog();
        }

        private void btnNewVenta_Click(object sender, EventArgs e)
        {
            NuevaVenta ventana = new NuevaVenta();
            ventana.ShowDialog();
        }

        private void btnEliminFactura_Click(object sender, EventArgs e)
        {
            BajaFactura ventana = new BajaFactura();
            ventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoHerramientasXetapas ventana = new ListadoHerramientasXetapas();
            ventana.ShowDialog();
        }
    }    
}


