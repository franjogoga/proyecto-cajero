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
        string strClave = "";
        string strClaveX = "";
        int flagLoginCuenta = 0;
        int flagLoginClave = 0;
        int flagDeposito = 0;
        int flagRetiro = 0;
        int flagPagos = 0;

        public VentanaCliente()
        {
            InitializeComponent();
            clientes = servicio.cargarClientes();
            flagLoginCuenta = 1;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "1";
                lblCentro3.Text = strCuenta;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "1";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "2";
                lblCentro3.Text = strCuenta;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "2";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "3";
                lblCentro3.Text = strCuenta;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "3";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "4";
                lblCentro3.Text = strCuenta;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "4";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "5";
                lblCentro3.Text = strCuenta;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "5";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "6";
                lblCentro3.Text = strCuenta;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "6";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "7";
                lblCentro3.Text = strCuenta;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "7";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "8";
                lblCentro3.Text = strCuenta;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "8";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "9";
                lblCentro3.Text = strCuenta;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "9";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "0";
                lblCentro3.Text = strCuenta;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "0";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                lblCentro3.Text = "";
                strCuenta = "";
            }
            if (flagLoginClave == 1)
            {
                strClave = "";
                strClaveX = "";
                lblCentro4.Text = "";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                flagLoginClave = 1;
            }
            if (flagLoginClave == 1)
            {
                if (servicio.validarCuenta(strCuenta, strClave))
                {

                }
            }
        }



    }
}
