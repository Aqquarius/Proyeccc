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
    public partial class MantenedorHabitaciones : Form
    {
        public MantenedorHabitaciones()
        {
            InitializeComponent();
            listarHabitacion();
            inicioComboBox();
            gbDatos.Enabled = false;
            btnCancelarHAB.Enabled = false;
        }
        private void inicioComboBox()
        {
            // cmbPiso
            cmbPisoHab.Items.Clear();
            List<string> pisos = logHabitacion.Instancia.obtenerPiso();
            foreach (string piso in pisos)
            {
                cmbPisoHab.Items.Add(piso);
            }
            // cmbTipo
            cmbTipoHab.Items.Clear();
            List<string> tipos = logHabitacion.Instancia.obtenerTipo();
            foreach (string tipo in tipos)
            {
                cmbTipoHab.Items.Add(tipo);
            }
        }
        public void listarHabitacion()
        {
            dgvHabitaciones.DataSource = CapaLogica.logHabitacion.Instancia.listarHabitacion();
        }
        private void limpiarVariables()
        {
            txtNumHab.Text = " ";
            txtPrecioHab.Text = " ";
        }

        private void btnNuevoHAB_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnAgregarHAB.Enabled = true;
            btnBuscarHAB.Enabled = true;
            btnDeshabilitarHAB.Enabled = false;
            btnModificarHAB.Enabled = false;
            btnCancelarHAB.Enabled = true;
        }

        private void btnEditarHAB_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnCancelarHAB.Enabled = true;
            btnAgregarHAB.Enabled = false;
            btnBuscarHAB.Enabled = true;
            btnDeshabilitarHAB.Enabled = true;
            btnModificarHAB.Enabled = true;
        }

        private void btnCancelarHAB_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = false;
            btnAgregarHAB.Enabled = false;
            btnBuscarHAB.Enabled = false;
            btnDeshabilitarHAB.Enabled = false;
            btnModificarHAB.Enabled = false;
            btnCancelarHAB.Enabled = false;
        }
        private void btnAgregarHAB_Click(object sender, EventArgs e)
        {
            try
            {
                entHabitacion hab = new entHabitacion();
                hab.Numero = txtNumHab.Text.Trim();
                hab.Precio = Convert.ToDecimal(txtPrecioHab.Text.Trim());
                hab.Piso = cmbPisoHab.SelectedItem.ToString();
                hab.Tipo = cmbTipoHab.SelectedItem.ToString();
                hab.Estado = true; // Puedes ajustar este valor según corresponda

                logHabitacion.Instancia.agregarHabitacion(hab);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            limpiarVariables();
            listarHabitacion();
        }
        private void btnBuscarHAB_Click(object sender, EventArgs e)
        {
            try
            {
                int habID = Convert.ToInt32(txtIDHab.Text.Trim());
                string numHab = txtNumHab.Text.Trim();
                entHabitacion hab = logHabitacion.Instancia.buscarHabitacion(habID, numHab);
                if (hab != null)
                {
                    txtNumHab.Text = hab.Numero;
                    txtPrecioHab.Text = hab.Precio.ToString();
                    cmbPisoHab.SelectedItem = hab.Piso;
                    cmbTipoHab.SelectedItem = hab.Tipo;
                }
                else
                {
                    MessageBox.Show("Habitación no encontrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnModificarHAB_Click(object sender, EventArgs e)
        {
            try
            {
                entHabitacion hab = new entHabitacion();
                hab.HabitacionID = int.Parse(txtIDHab.Text.Trim());
                hab.Numero = txtNumHab.Text.Trim();
                hab.Precio = Convert.ToDecimal(txtPrecioHab.Text.Trim());
                hab.Piso = cmbPisoHab.Text.Trim();
                hab.Tipo = cmbTipoHab.Text.Trim();
                hab.Estado = cbEstadoHab.Checked;
                logHabitacion.Instancia.modificarHabitacion(hab);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            gbDatos.Enabled = false;
            listarHabitacion();
        }
        private void btnDeshabilitarHAB_Click(object sender, EventArgs e)
        {
            try
            {
                entHabitacion h = new entHabitacion();

                h.HabitacionID = int.Parse(txtIDHab.Text.Trim());
                cbEstadoHab.Checked = false;
                h.Estado = cbEstadoHab.Checked;
                logHabitacion.Instancia.deshabilitarHabitacion(h);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            gbDatos.Enabled = false;
            listarHabitacion();
        }
    }
}
