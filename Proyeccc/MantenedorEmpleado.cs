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
    public partial class MantenedorEmpleado : Form
    {
        public MantenedorEmpleado()
        {
            InitializeComponent();
            listarEmpleado();
            inicioComboBox();
            gbDatos.Enabled = false;
            btnCancelarEMP.Enabled = false;
        }
        private void inicioComboBox()
        {
            // cmbGenero
            cmbGeneroEmp.Items.Clear();
            List<string> generos = logEmpleado.Instancia.obtenerGenero();
            foreach (string genero in generos)
            {
                cmbGeneroEmp.Items.Add(genero);
            }
            // cmbEstCiv
            cmbEstCivEmp.Items.Clear();
            List<string> estciviles = logEmpleado.Instancia.obtenerEstadoCivil();
            foreach (string estadocivil in estciviles)
            {
                cmbEstCivEmp.Items.Add(estadocivil);
            }
            // cmbEquipo
            cmbEquipoEmpleado.Items.Clear();
            List<string> equiposemp = logEmpleado.Instancia.obtenerEquipoTrabajo();
            foreach (string equipoemp in equiposemp)
            {
                cmbEquipoEmpleado.Items.Add(equipoemp);
            }
            // cmbTipo
            cmbTipoEmpleado.Items.Clear();
            List<string> tipos = logEmpleado.Instancia.obtenerTipoEmpleado();
            foreach (string tipo in tipos)
            {
                cmbTipoEmpleado.Items.Add(tipo);
            }
        }
        public void listarEmpleado()
        {
            dgvEmpleado.DataSource = CapaLogica.logEmpleado.Instancia.listarEmpleado();
        }
        private void limpiarVariables()
        {
            txtIDEmpleado.Text = "";
            txtNombreEmpleado.Text = " ";
            txtApellidosEmpleado.Text = " ";
            txtCorreoEmpleado.Text = " ";
            txtDescripcionEMP.Text = " ";
            txtDNIEmpleado.Text = " ";
            txtLugarNaEMP.Text = " ";
            txtTelefonoEmpleado.Text = " ";
        }

        private void btnNuevoEMP_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnAgregarEMP.Enabled = true;
            btnBuscarEMP.Enabled = true;
            btnInhabilitarEMP.Enabled = false;
            btnModificarEMP.Enabled = false;
            btnCancelarEMP.Enabled = true;
        }

        private void btnEditarEMP_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnCancelarEMP.Enabled = true;
            btnAgregarEMP.Enabled = false;
            btnBuscarEMP.Enabled = true;
            btnInhabilitarEMP.Enabled = true;
            btnModificarEMP.Enabled = true;
        }

        private void btnCancelarEMP_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = false;
            btnAgregarEMP.Enabled = false;
            btnBuscarEMP.Enabled = false;
            btnInhabilitarEMP.Enabled = false;
            btnModificarEMP.Enabled = false;
            btnCancelarEMP.Enabled = false;
        }

        private void btnAgregarEMP_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado em = new entEmpleado();
                em.DNI = txtDNIEmpleado.Text;
                em.Nombre = txtNombreEmpleado.Text;
                em.Apellido = txtApellidosEmpleado.Text;
                em.Correo = txtCorreoEmpleado.Text;
                em.Telefono = txtTelefonoEmpleado.Text;
                em.Fecha_Registro = Convert.ToDateTime(dtpEmpleado.Text);
                em.Descripcion = txtDescripcionEMP.Text;
                em.Estado = cbEstadoEmpleado.Checked;
                em.Pais = txtLugarNaEMP.Text;
                em.EstadoCivil = cmbEstCivEmp.Text;
                em.Genero = cmbGeneroEmp.Text;
                em.Tipo = cmbTipoEmpleado.Text;
                em.EquipoTrabajo = cmbEquipoEmpleado.Text;

                logEmpleado.Instancia.agregarEmpleado(em);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            limpiarVariables();
            listarEmpleado();
        }

        private void btnBuscarEMP_Click(object sender, EventArgs e)
        {
            try
            {
                int EmpID = Convert.ToInt32(txtIDEmpleado.Text.Trim());
                entEmpleado emple = logEmpleado.Instancia.buscarEmpleado(EmpID);
                if (emple != null)
                {
                    txtDNIEmpleado.Text = emple.DNI;
                    txtNombreEmpleado.Text = emple.Nombre;
                    txtApellidosEmpleado.Text = emple.Apellido;
                    txtCorreoEmpleado.Text = emple.Correo;
                    txtTelefonoEmpleado.Text = emple.Telefono;
                    dtpEmpleado.Value = emple.Fecha_Registro;
                    txtDescripcionEMP.Text = emple.Descripcion;
                    cbEstadoEmpleado.Checked = emple.Estado;
                    txtLugarNaEMP.Text = emple.Pais;
                    cmbEstCivEmp.Text = emple.EstadoCivil;
                    cmbGeneroEmp.Text = emple.Genero;
                    cmbTipoEmpleado.Text = emple.Tipo;
                    cmbEquipoEmpleado.Text = emple.EquipoTrabajo;

                    btnModificarEMP.Enabled = true;
                    btnInhabilitarEMP.Enabled = true;
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

        private void btnInhabilitarEMP_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado em = new entEmpleado();

                em.EmpleadoID = int.Parse(txtIDEmpleado.Text.Trim());
                cbEstadoEmpleado.Checked = false;
                em.Estado = cbEstadoEmpleado.Checked;
                logEmpleado.Instancia.deshabilitarEmpleado(em);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            gbDatos.Enabled = false;
            listarEmpleado();
        }
        private void btnModificarEMP_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado em = new entEmpleado();
                em.EmpleadoID = int.Parse(txtIDEmpleado.Text.Trim());
                em.DNI = txtDNIEmpleado.Text;
                em.Nombre = txtNombreEmpleado.Text;
                em.Apellido = txtApellidosEmpleado.Text;
                em.Correo = txtCorreoEmpleado.Text;
                em.Telefono = txtTelefonoEmpleado.Text;
                em.Fecha_Registro = Convert.ToDateTime(dtpEmpleado.Text);
                em.Descripcion = txtDescripcionEMP.Text;
                em.Estado = cbEstadoEmpleado.Checked;
                em.Pais = txtLugarNaEMP.Text;
                em.EstadoCivil = cmbEstCivEmp.Text;
                em.Genero = cmbGeneroEmp.Text;
                em.Tipo = cmbTipoEmpleado.Text;
                em.EquipoTrabajo = cmbEquipoEmpleado.Text;
                logEmpleado.Instancia.modificarEmpleado(em);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            gbDatos.Enabled = false;
            listarEmpleado();
        }
    }
}
