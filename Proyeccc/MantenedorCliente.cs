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
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
            listarUsuario();
            inicioComboBox();
            gbDatos.Enabled = false;
            btnCancelarCL.Enabled = false;
        }
        private void inicioComboBox()
        {
            // cmbGenero
            cmbGeneroCliente.Items.Clear();
            List<string> generos = logUsuario.Instancia.obtenerGenero();
            foreach (string genero in generos)
            {
                cmbGeneroCliente.Items.Add(genero);
            }
            // cmbEstCivCliente
            cmbEstCivCliente.Items.Clear();
            List<string> estciviles = logUsuario.Instancia.obtenerEstadoCivil();
            foreach (string estadocivil in estciviles)
            {
                cmbEstCivCliente.Items.Add(estadocivil);
            }
        }
        public void listarUsuario()
        {
            dgvCliente.DataSource = CapaLogica.logUsuario.Instancia.listarUsuario();
        }
        private void limpiarVariables()
        {
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = " ";
            txtCorreoCliente.Text = " ";
            txtTelefonoCliente.Text = " ";
        }

        private void btnNuevoCL_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnAgregarCL.Enabled = true;
            btnBuscarCL.Enabled = true;
            btnDeshabilitarCL.Enabled = false;
            btnModificarCL.Enabled = false;
            btnCancelarCL.Enabled = true;
        }

        private void btnAgregarCL_Click(object sender, EventArgs e)
        {
            try
            {
                entUsuario c = new entUsuario();
                c.DNI = txtDNICliente.Text;
                c.Nombre = txtNombreCliente.Text;
                c.Apellido = txtApellidoCliente.Text;
                c.Correo = txtCorreoCliente.Text;
                c.Telefono = txtTelefonoCliente.Text;
                c.Fecha_Registro = Convert.ToDateTime(dtpCliente.Text);
                c.Descripcion = txtDescripcionCliente.Text;
                c.Estado = cbEstadoCliente.Checked;
                c.Pais = txtPaisCliente.Text;
                c.EstadoCivil = cmbEstCivCliente.Text;
                c.Genero = cmbGeneroCliente.Text;

                logUsuario.Instancia.insertaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            limpiarVariables();
            listarUsuario();
        }

        private void btnCancelarCL_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = false;
            btnAgregarCL.Enabled = false;
            btnBuscarCL.Enabled = false;
            btnDeshabilitarCL.Enabled = false;
            btnModificarCL.Enabled = false;
            btnCancelarCL.Enabled = false;
        }

        private void btnBuscarCL_Click(object sender, EventArgs e)
        {
            try
            {
                int clienteID = Convert.ToInt32(txtClienteID.Text.Trim());
                entUsuario cliente = logUsuario.Instancia.BuscarClientePorID(clienteID);
                if (cliente != null)
                {
                    txtDNICliente.Text = cliente.DNI;
                    txtNombreCliente.Text = cliente.Nombre;
                    txtApellidoCliente.Text = cliente.Apellido;
                    txtCorreoCliente.Text = cliente.Correo;
                    txtTelefonoCliente.Text = cliente.Telefono;
                    dtpCliente.Value = cliente.Fecha_Registro;
                    txtDescripcionCliente.Text = cliente.Descripcion;
                    cbEstadoCliente.Checked = cliente.Estado;
                    txtPaisCliente.Text = cliente.Pais;
                    cmbEstCivCliente.Text = cliente.EstadoCivil;
                    cmbGeneroCliente.Text = cliente.Genero;

                    btnModificarCL.Enabled = true;
                    btnDeshabilitarCL.Enabled = true;
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

        private void btnModificarCL_Click(object sender, EventArgs e)
        {
            try
            {
                entUsuario c = new entUsuario();
                c.ClienteID = int.Parse(txtClienteID.Text.Trim());
                c.DNI = txtDNICliente.Text.Trim();
                c.Nombre = txtNombreCliente.Text.Trim();
                c.Apellido = txtApellidoCliente.Text.Trim();
                c.Correo = txtCorreoCliente.Text.Trim();
                c.Telefono = txtTelefonoCliente.Text.Trim();
                c.Fecha_Registro = dtpCliente.Value;
                c.Descripcion = txtDescripcionCliente.Text.Trim();
                c.Estado = cbEstadoCliente.Checked;
                c.Pais = txtPaisCliente.Text.Trim();
                c.EstadoCivil = cmbEstCivCliente.Text.Trim();
                c.Genero = cmbGeneroCliente.Text.Trim();
                logUsuario.Instancia.EditaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            gbDatos.Enabled = false;
            listarUsuario();
        }

        private void btnDeshabilitarCL_Click(object sender, EventArgs e)
        {
            try
            {
                entUsuario c = new entUsuario();

                c.ClienteID = int.Parse(txtClienteID.Text.Trim());
                cbEstadoCliente.Checked = false;
                c.Estado = cbEstadoCliente.Checked;
                logUsuario.Instancia.deshabilitarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            gbDatos.Enabled = false;
            listarUsuario();

        }
        private void btEditarCL_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnCancelarCL.Enabled = true;
            btnAgregarCL.Enabled = false;
            btnBuscarCL.Enabled = true;
            btnDeshabilitarCL.Enabled = true;
            btnModificarCL.Enabled = true;
        }
    }
}
