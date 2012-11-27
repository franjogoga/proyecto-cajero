using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Servicios;
using Libreria;

namespace proyecto_cajero
{
    public partial class VentanaUsuario : Form
    {
        Bienvenida bienvenida = null;
        Servicio servicio = new Servicio();
        List<Usuario> usuarios = new List<Usuario>();
        List<Cuenta> cuentas = new List<Cuenta>();
        List<Cliente> clientes = new List<Cliente>();

        public VentanaUsuario()
        {
            InitializeComponent();
            usuarios = servicio.cargarUsuarios();
            clientes = servicio.cargarClientes();
            cuentas = servicio.cargarCuentas();            
        }

        public void setBienvenida(Bienvenida bienvenida)
        {
            this.bienvenida = bienvenida;
        }
        public Bienvenida getBienvenida()
        {
            return bienvenida;
        }

        private void VentanaUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            bienvenida.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }



    }
}
