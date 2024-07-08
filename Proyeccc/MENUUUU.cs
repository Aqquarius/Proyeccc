using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyeccc
{
    public partial class MENUUUU : Form
    {
        public MENUUUU()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnRegistroCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MantenedorCliente>();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        public void MostrarFormularioMantenedorEmpleado()
        {
            AbrirFormulario<MantenedorEmpleado>();
        }
        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnRegistroEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Login>();
        }

        private void btnRegistroPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MantenedorFormasdePago>();
        }

        private void btnTipodeHabitaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MantenedorHabitaciones>();
        }

        private void btnOrdenConserjeria_Click(object sender, EventArgs e)
        {
            AbrirFormulario<OrdenConserjeria>();
        }

        private void btnOrdenReserva_Click(object sender, EventArgs e)
        {
            AbrirFormulario<OrdenReserva>();
        }

        private void btnOrdenHospedaje_Click(object sender, EventArgs e)
        {
            AbrirFormulario<OrdenHospedaje>();
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MantenedorEquipoTrabajo>();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
