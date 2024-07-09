using System;
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
    public partial class OrdenConserjeria : Form
    {
        public OrdenConserjeria()
        {
            InitializeComponent();
            inicioComboBox();
            listarConserjeria();
            gb1.Enabled = false;
            gb2.Enabled = false;
            btnCancelarRESER.Enabled = false;
        }
        private void inicioComboBox()
        {
            // cmbEquipoConserjeria
            cmbEquipoConserjeria.Items.Clear();
            List<string> equipos = logConserjeria.Instancia.obtenerEquipoTrabajo();
            foreach (string equipo in equipos)
            {
                cmbEquipoConserjeria.Items.Add(equipo);
            }
            // cmbHabConserjeria
            cmbHabConserjeria.Items.Clear();
            List<string> habitaciones = logConserjeria.Instancia.obtenerHabitacion();
            foreach (string habitacion in habitaciones)
            {
                cmbHabConserjeria.Items.Add(habitacion);
            }
            // cmbHabConserjeria
            cmbTipoOrdenCons.Items.Clear();
            List<string> tipoordenes = logConserjeria.Instancia.obtenerTipoOrden();
            foreach (string tipoorden in tipoordenes)
            {
                cmbTipoOrdenCons.Items.Add(tipoorden);
            }
        }
        public void listarConserjeria()
        {
            dgvConserjeria.DataSource = CapaLogica.logConserjeria.Instancia.listarConserjeria();
        }
        private void limpiarVariables()
        {
            txtIDClienteRes.Text = "";
            txtIDConserjeria.Text = " ";
            txtClienteConserjeria.Text = " ";
        }
        private void btnNuevoRESER_Click(object sender, EventArgs e)
        {
            gb1.Enabled = true;
            gb2.Enabled = true;
            btnAgregarOrdenConCONSER.Enabled = true;
            btnFinalizarOrdenCONSER.Enabled = true;
            btnBuscarClienteCONSER.Enabled = true;
            btnNuevoRESER.Enabled = true;
            btnEditarRESER.Enabled = false;
            btnCancelarRESER.Enabled = true;
        }

        private void btnEditarRESER_Click(object sender, EventArgs e)
        {
            gb1.Enabled = true;
            gb2.Enabled = true;
            btnAgregarOrdenConCONSER.Enabled = false;
            btnFinalizarOrdenCONSER.Enabled = true;
            btnBuscarClienteCONSER.Enabled = true;
            btnNuevoRESER.Enabled = false;
            btnEditarRESER.Enabled = true;
            btnCancelarRESER.Enabled = true;
        }

        private void btnCancelarRESER_Click(object sender, EventArgs e)
        {
            gb1.Enabled = false;
            gb2.Enabled = false;
            btnAgregarOrdenConCONSER.Enabled = false;
            btnFinalizarOrdenCONSER.Enabled = false;
            btnBuscarClienteCONSER.Enabled = false;
            btnNuevoRESER.Enabled = true;
            btnEditarRESER.Enabled = true;
            btnCancelarRESER.Enabled = true;
        }

        private void btnAgregarOrdenConCONSER_Click(object sender, EventArgs e)
        {
            try
            {
                entConserjeria con = new entConserjeria();
                con.Cliente = txtClienteConserjeria.Text;
                con.Habitacion = cmbHabConserjeria.Text;
                con.Equipo = cmbEquipoConserjeria.Text;
                con.Tipo_Orden = cmbTipoOrdenCons.Text;
                con.Estado = cbEstadoCons.Checked;
                con.Fecha_Orden = Convert.ToDateTime(dtpOrdenConserjeria.Text);

                logConserjeria.Instancia.agregaConserjeria(con);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            limpiarVariables();
            listarConserjeria();
        }

        private void btnFinalizarOrdenCONSER_Click(object sender, EventArgs e)
        {
            try
            {
                entConserjeria c = new entConserjeria();

                c.ConserjeriaID = int.Parse(txtIDConserjeria.Text.Trim());
                cbEstadoCons.Checked = false;
                c.Estado = cbEstadoCons.Checked;
                logConserjeria.Instancia.deshabilitarConserjeria(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            gb1.Enabled = false;
            gb2.Enabled = false;
            listarConserjeria();
        }

        private void btnBuscarClienteCONSER_Click(object sender, EventArgs e)
        {
            int clienteID;
            if (!int.TryParse(txtIDClienteRes.Text, out clienteID))
            {
                MessageBox.Show("Por favor, ID Cliente valido");
                return;
            }

            try
            {
                entUsuario cliente = logUsuario.Instancia.BuscarCliente(clienteID);
                if (cliente != null)
                {
                    txtClienteConserjeria.Text = cliente.Nombre;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}
