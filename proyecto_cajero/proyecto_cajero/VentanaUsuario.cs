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
        List<Cuenta> consultaCuentas = new List<Cuenta>();

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

        public void llenaDgvClientes()
        {
            dgvClientes.Rows.Clear();
            Cliente cli = null;
            int fila = 0;
            foreach (Cuenta c in consultaCuentas)
            {
                cli = servicio.buscaCliente( c.getDni() );
                fila = dgvClientes.Rows.Add();
                dgvClientes.Rows[fila].Cells["DNI"].Value = cli.getDni();
                dgvClientes.Rows[fila].Cells["NombreCompleto"].Value = cli.getNombre() + " "+ cli.getapellidoPaterno() + " "+cli.getapellidoMaterno();
                dgvClientes.Rows[fila].Cells["NumeroCuenta"].Value = c.getNumero();
                dgvClientes.Rows[fila].Cells["Saldo"].Value = c.getSaldo();
                dgvClientes.Rows[fila].Cells["Tipo"].Value = c.getTipo();
                dgvClientes.Rows[fila].Cells["Moneda"].Value = c.getMoneda();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (cmbCriterio.SelectedItem.ToString().Equals("Todos los Clientes"))
            {
                consultaCuentas = cuentas;
                llenaDgvClientes();
                return;
            }
            if (cmbCriterio.SelectedItem.ToString().Equals("Tipo de Cuenta"))
            {
                consultaCuentas = servicio.consultaCuentaPorTipo(txtCriterio.Text);
                llenaDgvClientes();
                return;
            }
            if (cmbCriterio.SelectedItem.ToString().Equals("Tipo de Moneda"))
            {
                consultaCuentas = servicio.consultaCuentaPorMoneda(txtCriterio.Text);
                llenaDgvClientes();
                return;
            }

        }



    }
}
