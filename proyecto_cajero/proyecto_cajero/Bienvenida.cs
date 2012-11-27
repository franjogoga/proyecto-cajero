using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyecto_cajero
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();            
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            VentanaCliente ventanaCliente = new VentanaCliente();
            ventanaCliente.setBienvenida(this);
            this.Hide();            
            ventanaCliente.Show();            
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            VentanaUsuario ventanaUsuario = new VentanaUsuario();
            ventanaUsuario.setBienvenida(this);
            this.Hide();
            ventanaUsuario.Show();
        }

        private void Bienvenida_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }


    }
}
