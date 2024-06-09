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
                    password = File.ReadAllText(url);
                    if (contra.Equals(password))
                    {
                        Inicio mostrarI = new Inicio();
                        mostrarI.Show();
                    }
                    else
                    {
                        MessageBox.Show(txContraseña, "Contraseña Incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show(txUsuario, "Usuario Incorrecto");
                }
            }
            else if (btInicarSesion.Text == "Registrarse")
            {
                string Usuario;
                string Contraseña;

                if (txUsuario.Text == "Usuario")
                {
                    MessageBox.Show("Escribe un nombre");
                    return;
                }
                else
                {
                    Usuario = Convert.ToString(txUsuario.Text);
                }
                if (txContraseña.Text == "Contraseña")
                {
                    MessageBox.Show("Escribe una contraseña");
                    return;
                }
                else
                {
                    Contraseña = Convert.ToString(txContraseña.Text);
                }

                string usuario = txUsuario.Text;
                string contra = txContraseña.Text;
                string url = usuario + ".txt";
                if (File.Exists(url))
                {
                    MessageBox.Show("Usuario existente");
                }
                else
                {
                    File.WriteAllText(url, contra);
                    MessageBox.Show("Usuario registrado");
                    txUsuario.Text = "Usuario";
                    txContraseña.Text = "Contraseña";
                }
            }
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (btInicarSesion.Text == "Iniciar Sesión")
            {
                btInicarSesion.Text = "Registrarse";
                btRegistrar.Text = "Iniciar Sesión";
            }
            else if (btInicarSesion.Text == "Registrarse")
            {
                btInicarSesion.Text = "Iniciar Sesión";
                btRegistrar.Text = "Registrarse";
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
