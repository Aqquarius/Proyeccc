﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            // que se muestre con el show 
            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;

        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            this.Show();
        }
    
    }
}