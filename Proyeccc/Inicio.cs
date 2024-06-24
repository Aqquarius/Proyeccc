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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            MantenedorCliente mCliente = new MantenedorCliente();
            mCliente.Show();
        }
    }
}
