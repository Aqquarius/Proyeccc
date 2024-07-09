using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyeccc
{
    public partial class MantenedorFormasdePago : Form
    {
        public MantenedorFormasdePago()
        {
            InitializeComponent();
            listarMP();
            gbDatos.Enabled = false;
            btnCancelarMPAGO.Enabled = false;
        }
        public void listarMP()
        {
            dgvMetodoPago.DataSource = CapaLogica.logMetodoPago.Instancia.listarMetPag();
        }
        private void limpiarVariables()
        {
            txtIDMP.Text = "";
            txtDescripcionPago.Text = "";
            txtNombreMP.Text = "";
        }

        private void btnNuevoMPAGO_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnAgregarMPAGO.Enabled = true;
            btnBuscarMPAGO.Enabled = true;
            btnModificarMPAGO.Enabled = false;
            btnDeshabilitarMPAGO.Enabled = false;
            btnCancelarMPAGO.Enabled = true;
        }

        private void btnEditarMPAGO_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnAgregarMPAGO.Enabled = false;
            btnBuscarMPAGO.Enabled = true;
            btnModificarMPAGO.Enabled = true;
            btnDeshabilitarMPAGO.Enabled = true;
            btnCancelarMPAGO.Enabled = true;
        }

        private void btnCancelarMPAGO_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = false;
            btnAgregarMPAGO.Enabled = false;
            btnBuscarMPAGO.Enabled = false;
            btnModificarMPAGO.Enabled = false;
            btnDeshabilitarMPAGO.Enabled = false;
            btnCancelarMPAGO.Enabled = true;
        }

        private void btnAgregarMPAGO_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago mp = new entMetodoPago();
                mp.Nombre = txtNombreMP.Text;
                mp.Descripcion = txtDescripcionPago.Text;
                mp.Estado = cbEstadoPago.Checked;

                logMetodoPago.Instancia.agregarMetPag(mp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            limpiarVariables();
            listarMP();
        }

        private void btnBuscarMPAGO_Click(object sender, EventArgs e)
        {
            try
            {
                int mpID = Convert.ToInt32(txtIDMP.Text.Trim());
                entMetodoPago equipo = logMetodoPago.Instancia.buscarMetPag(mpID);
                if (equipo != null)
                {
                    txtNombreMP.Text = equipo.Nombre;
                    txtDescripcionPago.Text = equipo.Descripcion;
                    cbEstadoPago.Checked = equipo.Estado;

                    btnModificarMPAGO.Enabled = true;
                    btnDeshabilitarMPAGO.Enabled = true;
                    gbDatos.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un ID de cliente válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDeshabilitarMPAGO_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago mp = new entMetodoPago();

                mp.MetodoPagoID = int.Parse(txtIDMP.Text.Trim());
                cbEstadoPago.Checked = false;
                mp.Estado = cbEstadoPago.Checked;
                logMetodoPago.Instancia.deshabilitarMetPag(mp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            gbDatos.Enabled = false;
            listarMP();
        }

        private void btnModificarMPAGO_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago mp = new entMetodoPago();
                mp.MetodoPagoID = int.Parse(txtIDMP.Text.Trim());
                mp.Nombre = txtNombreMP.Text.Trim();
                mp.Descripcion = txtDescripcionPago.Text.Trim();
                mp.Estado = cbEstadoPago.Checked;
                logMetodoPago.Instancia.modificarMetPag(mp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            gbDatos.Enabled = false;
            listarMP();
        }
    }
}
