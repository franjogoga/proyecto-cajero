using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Libreria;
using Servicios;

namespace proyecto_cajero
{
    public partial class VentanaCliente : Form
    {
        Servicio servicio = new Servicio();
        List<Cliente> clientes = new List<Cliente>();
        string strCuenta = "";
        int flagInicio = 0;
        int flagDeposito = 0;
        int flagRetiro = 0;
        int flagPagos = 0;

        public VentanaCliente()
        {
            InitializeComponent();
            clientes = servicio.cargarClientes();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            strCuenta = strCuenta + "1";
            lblCentro3.Text = strCuenta;            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            strCuenta = strCuenta + "2";
            lblCentro3.Text = strCuenta;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            strCuenta = strCuenta + "3";
            lblCentro3.Text = strCuenta;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            strCuenta = strCuenta + "4";
            lblCentro3.Text = strCuenta;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            strCuenta = strCuenta + "5";
            lblCentro3.Text = strCuenta;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            strCuenta = strCuenta + "6";
            lblCentro3.Text = strCuenta;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            strCuenta = strCuenta + "7";
            lblCentro3.Text = strCuenta;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            strCuenta = strCuenta + "8";
            lblCentro3.Text = strCuenta;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            strCuenta = strCuenta + "9";
            lblCentro3.Text = strCuenta;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            strCuenta = strCuenta + "0";
            lblCentro3.Text = strCuenta;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblCentro3.Text = "";
            strCuenta = "";
        }



    }
}
