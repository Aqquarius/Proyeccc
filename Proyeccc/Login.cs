using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyeccc
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string password;

        private void btInicarSesion_Click(object sender, EventArgs e)
        {
            if (btInicarSesion.Text == "Iniciar Sesión")
            {
                string usuario = txUsuario.Text;
                string contra = txContraseña.Text;
                string url = usuario + ".txt";

                if (File.Exists(url))
                {
                    string password = File.ReadAllText(url);

                    if (contra.Equals(password))
                    {
                        MENUUUU menu = Application.OpenForms["MENUUUU"] as MENUUUU;
                        if (menu != null)
                        {
                            menu.AbrirFormulario<MantenedorEmpleado>();
                        }
                        else
                        {
                            MessageBox.Show("Error: No se pudo encontrar el formulario MENUUUU");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario Incorrecto");
                }
            }
        }
        private void txUsuario_Enter(object sender, EventArgs e)
        {
            if (txUsuario.Text == "Usuario")
            {
                txUsuario.Text = "";
                txUsuario.ForeColor = Color.Black;
            }
        }
        private void txUsuario_Leave(object sender, EventArgs e)
        {
            if (txUsuario.Text == "")
            {
                txUsuario.Text = "Usuario";
                txUsuario.ForeColor = Color.Gray;
            }
        }
        private void txContraseña_Enter(object sender, EventArgs e)
        {
            if (txContraseña.Text == "Contraseña")
            {
                txContraseña.Text = "";
                txContraseña.ForeColor = Color.Black;
                txContraseña.UseSystemPasswordChar = true;
            }
        }
        private void txContraseña_Leave(object sender, EventArgs e)
        {
            if (txContraseña.Text == "")
            {
                txContraseña.Text = "Contraseña";
                txContraseña.ForeColor = Color.Gray;
                txContraseña.UseSystemPasswordChar = false;
            }
        }
    }
}
