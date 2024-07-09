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
    public partial class OrdenReserva : Form
    {
        public OrdenReserva()
        {
            InitializeComponent();
            listarReserva();
            inicioComboBox();
            gbDatos.Enabled = false;
            btnCancelarRESER.Enabled = false;
        }
        private void inicioComboBox()
        {
            // cmbHabitacionRes
            cmbHabitacionRes.Items.Clear();
            List<string> habitaciones = logReserva.Instancia.obtenerHabitacion();
            foreach (string habitacion in habitaciones)
            {
                cmbHabitacionRes.Items.Add(habitacion);
            }
            // cmbMPRes
            cmbMPRes.Items.Clear();
            List<string> metpagos = logReserva.Instancia.obtenerMP();
            foreach (string estadocivil in metpagos)
            {
                cmbMPRes.Items.Add(estadocivil);
            }
        }
        public void listarReserva()
        {
            dgvReserva.DataSource = CapaLogica.logReserva.Instancia.listarReserva();
        }
        private void limpiarVariables()
        {
            txtClienteRes.Text = "";
            txtIDClienteRes.Text = " ";
            txtIDReserva.Text = " ";
            txtMotivoRes.Text = " ";
            txtPrecioRES.Text = " ";
        }
        private void btnBuscarClienteRESER_Click(object sender, EventArgs e)
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
                    txtClienteRes.Text = cliente.Nombre;
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

        private void btnNuevoRESER_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnAgregarRES.Enabled = true;
            btnBuscarClienteRESER.Enabled = true;
            btnMostrarRESER.Enabled = true;
            btnEditarRESER.Enabled = false;
            btnCancelarRESER.Enabled = true;
        }

        private void btnEditarRESER_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnAgregarRES.Enabled = false;
            btnBuscarClienteRESER.Enabled = true;
            btnMostrarRESER.Enabled = true;
            btnNuevoRESER.Enabled = false;
            btnEditarRESER.Enabled = true;
            btnCancelarRESER.Enabled = true;
        }

        private void btnCancelarRESER_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = false;
            btnAgregarRES.Enabled = false;
            btnBuscarClienteRESER.Enabled = false;
            btnMostrarRESER.Enabled = false;
            btnNuevoRESER.Enabled = true;
            btnEditarRESER.Enabled = true;
            btnCancelarRESER.Enabled = true;
        }

        private void btnAgregarRES_Click(object sender, EventArgs e)
        {
            try
            {
                entReserva res = new entReserva();
                res.Cliente = txtClienteRes.Text;
                res.Habitacion = cmbHabitacionRes.Text;
                res.Metodo_Pago = cmbMPRes.Text;
                res.Estado = cbEstadoRES.Checked;
                res.Motivo_Viaje = txtMotivoRes.Text;
                res.Precio = Convert.ToDecimal(txtPrecioRES.Text);
                res.Fecha_Registro = Convert.ToDateTime(dtpRegistroRes.Text);
                res.Fecha_Entrada = Convert.ToDateTime(dtpEntradaRes.Text);
                res.Fecha_Salida = Convert.ToDateTime(dtpSalidaRes.Text);

                logReserva.Instancia.agregarReserva(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            limpiarVariables();
            listarReserva();
        }

        private void btnMostrarRESER_Click(object sender, EventArgs e)
        {
            string habitacionSeleccionada = cmbHabitacionRes.SelectedItem.ToString();

            int habitacionID = 0;
            foreach (entHabitacion habitacion in logHabitacion.Instancia.listarHabitacion())
            {
                if (habitacion.Numero == habitacionSeleccionada)
                {
                    habitacionID = habitacion.HabitacionID;
                    break;
                }
            }

            entHabitacion habitacionEncontrada = logHabitacion.Instancia.buscarHabitacion(habitacionID, null);

            if (habitacionEncontrada != null)
            {
                txtPrecioRES.Text = habitacionEncontrada.Precio.ToString();
            }
            else
            {
                MessageBox.Show("La habitación seleccionada no fue encontrada en la base de datos.");
            }
        }
        private void btnAnularRES_Click(object sender, EventArgs e)
        {
            try
            {
                entReserva r = new entReserva();

                r.ReservaID = int.Parse(txtIDReserva.Text.Trim());
                cbEstadoRES.Checked = false;
                r.Estado = cbEstadoRES.Checked;
                logReserva.Instancia.deshabilitarReserva(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            gbDatos.Enabled = false;
            listarReserva();
        }
    }
}
