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
        List<Cuenta> cuentas = new List<Cuenta>();
        string strCuenta = "";
        string strClave = "";
        string strClaveX = "";
        int numeroCuenta = 0;
        int clave = 0;
        int dni = 0;
        int flagLoginCuenta = 0;
        int flagLoginClave = 0;
        int flagOpciones = 0;
        int flagDeposito = 0;
        int flagRetiro = 0;
        int flagPagos = 0;
        int vecesLogin = 0;

        public VentanaCliente()
        {
            InitializeComponent();
            clientes = servicio.cargarClientes();
            cuentas = servicio.cargarCuentas();
            flagLoginCuenta = 1;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "1";
                lblCentro3.Text = strCuenta;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "1";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "2";
                lblCentro3.Text = strCuenta;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "2";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "3";
                lblCentro3.Text = strCuenta;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "3";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "4";
                lblCentro3.Text = strCuenta;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "4";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "5";
                lblCentro3.Text = strCuenta;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "5";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "6";
                lblCentro3.Text = strCuenta;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "6";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "7";
                lblCentro3.Text = strCuenta;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "7";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "8";
                lblCentro3.Text = strCuenta;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "8";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "9";
                lblCentro3.Text = strCuenta;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "9";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "0";
                lblCentro3.Text = strCuenta;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "0";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                lblCentro3.Text = "";
                strCuenta = "";
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = "";
                strClaveX = "";
                lblCentro4.Text = "";
                return;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {                                    
            if (flagLoginCuenta == 1)
            {
                flagLoginCuenta = 0;
                flagLoginClave = 1;
                return;
            }
            if (flagLoginClave == 1)
            {
                vecesLogin = vecesLogin + 1;                

                numeroCuenta = servicio.convierteNumeroCuenta(strCuenta);
                clave = servicio.convierteClave(strClave);
                if (servicio.validarCuenta(numeroCuenta, clave))
                {
                    flagLoginCuenta = 0;
                    flagLoginClave = 0;
                    flagOpciones = 1;
                    dni = servicio.buscaCuenta(numeroCuenta).getDni();
                    lblBienvenido.Text = "Bienvenido Sr(a). "+servicio.buscaCliente(dni).getNombre()+ " "+servicio.buscaCliente(dni).getapellidoPaterno();
                    lblCentro1.Text = "Seleccione una operación";
                    lblCentro2.Text = "";                    
                    lblCentro3.Text = "";
                    lblCentro4.Text = "";
                    lblCuenta.Text = "";
                    lblClave.Text = "";



                }
                else
                {
                    if (vecesLogin == 3)
                    {
                        MessageBox.Show("Cuenta no válida, contacte con nuestro servicio para su ayuda");
                        this.Close();
                    }
                    flagLoginCuenta = 0;
                    flagLoginClave = 1;
                    flagOpciones = 0;
                    lblBienvenido.Text = "";
                    strClave = "";
                    strClaveX = "";
                    lblCentro1.Text = "";
                    lblCentro2.Text = "Clave no válida, intente nuevamente";
                    lblCentro3.Text = strCuenta;
                    lblCentro4.Text = "";
                }
                return;
            }
        }



    }
}
