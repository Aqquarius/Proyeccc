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
    public partial class MantenedorEquipoTrabajo : Form
    {
        public MantenedorEquipoTrabajo()
        {
            InitializeComponent();
            listarEquipo();
            gbDatos.Enabled = false;
            btnCancelarET.Enabled = false;
        }
        public void listarEquipo()
        {
            dgvEquipo.DataSource = CapaLogica.logEquipo.Instancia.listarEquipo();
        }
        private void limpiarVariables()
        {
            txtIDET.Text = "";
            txtNombreET.Text = "";
        }

        private void btnNuevoET_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnAgregarET.Enabled = true;
            btnBuscarET.Enabled = true;
            btnModET.Enabled = false;
            btnDeshabilitarET.Enabled = false;
            btnCancelarET.Enabled = true;
        }

        private void btnEditarET_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnAgregarET.Enabled = false;
            btnBuscarET.Enabled = true;
            btnModET.Enabled = true;
            btnDeshabilitarET.Enabled = true;
            btnCancelarET.Enabled = true;
        }

        private void btnCancelarET_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = false;
            btnAgregarET.Enabled = false;
            btnBuscarET.Enabled = false;
            btnModET.Enabled = false;
            btnDeshabilitarET.Enabled = false;
            btnCancelarET.Enabled = true;
        }

        private void btnAgregarET_Click(object sender, EventArgs e)
        {
            try
            {
                entEquipo c = new entEquipo();
                c.Nombre = txtNombreET.Text;
                c.Estado = cbEstadoET.Checked;

                logEquipo.Instancia.agregaEquipo(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            limpiarVariables();
            listarEquipo();
        }

        private void btnBuscarET_Click(object sender, EventArgs e)
        {
            try
            {
                int equipoID = Convert.ToInt32(txtIDET.Text.Trim());
                entEquipo equipo = logEquipo.Instancia.buscarEquipo(equipoID);
                if (equipo != null)
                {
                    txtNombreET.Text = equipo.Nombre;
                    cbEstadoET.Checked = equipo.Estado;

                    btnModET.Enabled = true;
                    btnDeshabilitarET.Enabled = true;
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

        private void btnDeshabilitarET_Click(object sender, EventArgs e)
        {
            try
            {
                entEquipo et = new entEquipo();

                et.EquipoID = int.Parse(txtIDET.Text.Trim());
                cbEstadoET.Checked = false;
                et.Estado = cbEstadoET.Checked;
                logEquipo.Instancia.deshabilitarEquipo(et);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            gbDatos.Enabled = false;
            listarEquipo();
        }

        private void btnModET_Click(object sender, EventArgs e)
        {
            try
            {
                entEquipo et = new entEquipo();
                et.EquipoID = int.Parse(txtIDET.Text.Trim());
                et.Nombre = txtNombreET.Text.Trim();
                et.Estado = cbEstadoET.Checked;
                logEquipo.Instancia.modificarEquipo(et);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            gbDatos.Enabled = false;
            listarEquipo();

        }
    }
}
