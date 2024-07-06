﻿using CapaEntidad;
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
            gbDatos.Enabled = false;
            gbOpciones.Enabled = false;
            btnCancelarCL.Enabled = false;
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
            gbOpciones.Enabled = true;
            btnCancelarCL.Enabled = true;
        }

        private void btnAgregarCL_Click(object sender, EventArgs e)
        {
            try
            {
                entUsuario c = new entUsuario();
                c.dni = txtDNICliente.Text;
                c.nombre = txtNombreCliente.Text;
                c.apellido = txtApellidoCliente.Text;
                c.correo = txtCorreoCliente.Text;
                c.telefono = txtTelefonoCliente.Text;
                c.fecha_registro = Convert.ToDateTime(dtpCliente.Text);

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
            btnCancelarCL.Enabled = false;
        }

        private void btnBuscarCL_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarCL_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            dgvCliente.Enabled = true;
            btnBuscarCL.Enabled = true;
            btnCancelarCL.Enabled = true;
        }

        private void btnDeshabilitarCL_Click(object sender, EventArgs e)
        {
            try
            {
                entUsuario c = new entUsuario();

                c.ClienteID = int.Parse(txtClienteID.Text.Trim());
                cbEstadoCliente.Checked = false;
                c.estado = cbEstadoCliente.Checked;
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
    }
}
