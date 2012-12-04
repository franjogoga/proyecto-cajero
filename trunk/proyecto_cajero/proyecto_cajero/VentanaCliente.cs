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
        Bienvenida bienvenida = null;
        Servicio servicio = new Servicio();
        List<Cliente> clientes = new List<Cliente>();
        List<Cuenta> cuentas = new List<Cuenta>();        
        string strCuenta = "";
        string strClave = "";
        string strClaveX = "";
        string strMontoDeposito = "";
        string strMontoRetiro = "";
        string strMontoPagoAgua = "";
        string strCuentaTranferencia = "";
        string strMontoTransferencia = "";
        string moneda = "";
        string monedaTranferencia = "";
        int numeroCuenta = 0;
        float saldo = 0;
        int clave = 0;
        int dni = 0;
        int flagMensajeMontoDeposito = 0;
        int flagMensajeRetiro = 0;
        int montoDeposito = 0;
        int flagLoginCuenta = 0;
        int flagLoginClave = 0;
        int flagOpciones = 0;
        int flagSaldo = 0;
        int flagDeposito = 0;
        int flagMontoDeposito = 0;
        int flagRetiro = 0;
        int flagPagos = 0;
        int flagPagoAgua = 0;
        int flagMensajePagoAgua = 0;
        int flagTransferencia = 0;
        int flagCuentaTransferenciaInvalida = 0;
        int flagCuentaMontoTransferencia = 0;
        int cuentaTransferencia = 0;
        int montoPagoAgua = 0;
        int vecesLogin = 0;        
        float montoTransferencia = 0;
        float saldoTransferencia = 0;
        int flagMensajeTranferencia = 0;
        
        public VentanaCliente()
        {
            InitializeComponent();
            clientes = servicio.cargarClientes();
            cuentas = servicio.cargarCuentas();
            cargaPanelLogin();
            flagLoginCuenta = 1;                        
        }
        public void setBienvenida(Bienvenida bienvenida)
        {
            this.bienvenida = bienvenida;
        }
        public Bienvenida getBienvenida()
        {
            return bienvenida;
        }
        public void cargaPanelLogin()
        {
            lblBienvenido.Text = "Bienvenido a su cajero";
            lblCentro1.Text = "Ingrese su numero de cuenta";
            lblCentro2.Text = "";
            lblCuenta.Text = "Numero de Cuenta :";
            lblClave.Text = "Clave                           :";
            lblCentro3.Text = "______";
            lblCentro4.Text = "____";
            lblIzq1.Text = "";
            lblIzq2.Text = "";
            lblIzq3.Text = "";
            lblIzq4.Text = "";
            lblDer1.Text = "";
            lblDer2.Text = "";
            lblDer3.Text = "";
            lblDer4.Text = "";
        }
        public void cargaPanelOpciones()
        {
            Cuenta c = servicio.buscaCuenta(numeroCuenta);
            dni = c.getDni();
            //dni = servicio.buscaCuenta(numeroCuenta).getDni();
            lblBienvenido.Text = "Bienvenido Sr(a). " + servicio.buscaCliente(dni).getNombre() + " " + servicio.buscaCliente(dni).getapellidoPaterno();
            lblCentro1.Text = "Seleccione una operación";
            lblCentro2.Text = "";
            lblCentro3.Text = "";
            lblCentro4.Text = "";
            lblCuenta.Text = "";
            lblClave.Text = "";
            lblIzq1.Text = "";
            lblIzq2.Text = "Depósitos";
            lblIzq3.Text = "Pagos";
            lblIzq4.Text = "Datos Personales y Saldos";
            lblDer1.Text = "";
            lblDer2.Text = "Retiros";            
            lblDer3.Text = "Transferencias";            
            lblDer4.Text = "Salir";
        }
        public void cargaPanelLoginInvalido()
        {
            lblBienvenido.Text = "";
            lblCentro1.Text = "";
            lblCentro2.Text = "Clave no válida, intente nuevamente";
            lblCentro3.Text = strCuenta;
            lblCentro4.Text = "____";
            lblCuenta.Text = "Numero de Cuenta :";
            lblClave.Text = "Clave                           :";            
            lblIzq1.Text = "";
            lblIzq2.Text = "";
            lblIzq3.Text = "";
            lblIzq4.Text = "";
            lblDer1.Text = "";
            lblDer2.Text = "";
            lblDer3.Text = "";
            lblDer4.Text = "";
        }
        public void cargaPanelMensajeDeposito()
        {
            lblBienvenido.Text = "";
            lblCentro1.Text = "";
            lblCentro2.Text = "Se han ingresado " +strMontoDeposito+ " "+servicio.buscaCuenta(numeroCuenta).getMoneda() + " a su cuenta";
            lblCentro3.Text = "";
            lblCentro4.Text = "";
            lblCuenta.Text = "";
            lblClave.Text = "";
            lblIzq1.Text = "";
            lblIzq2.Text = "";
            lblIzq3.Text = "";
            lblIzq4.Text = "Salir";
            lblDer1.Text = "";
            lblDer2.Text = "";
            lblDer3.Text = "";
            lblDer4.Text = "Otra Transacción";                        
        }
        public void cargaPanelDeposito()
        {
            lblBienvenido.Text = "Bienvenido Sr(a). " + servicio.buscaCliente(dni).getNombre() + " " + servicio.buscaCliente(dni).getapellidoPaterno();
            lblCentro1.Text = "Ingrese el monto del depósito";
            lblCentro2.Text = "______";
            lblCentro3.Text = "";
            lblCentro4.Text = "";
            lblCuenta.Text = "";
            lblClave.Text = "";
            lblIzq1.Text = "";
            lblIzq2.Text = "";
            lblIzq3.Text = "";
            lblIzq4.Text = "";
            lblDer1.Text = "";
            lblDer2.Text = "";
            lblDer3.Text = "";
            lblDer4.Text = "";
        }
        public void cargaPanelRetiro()
        {
            lblBienvenido.Text = "Bienvenido Sr(a). " + servicio.buscaCliente(dni).getNombre() + " " + servicio.buscaCliente(dni).getapellidoPaterno();
            lblCentro1.Text = "Ingrese el monto del retiro";
            lblCentro2.Text = "______";
            lblCentro3.Text = "";
            lblCentro4.Text = "";
            lblCuenta.Text = "";
            lblClave.Text = "";
            lblIzq1.Text = "";
            lblIzq2.Text = "";
            lblIzq3.Text = "";
            lblIzq4.Text = "";
            lblDer1.Text = "";
            lblDer2.Text = "";
            lblDer3.Text = "";
            lblDer4.Text = "";
        }
        public void cargaPanelRetiroInvalido()
        {
            lblBienvenido.Text = "";
            lblCentro1.Text = "";
            lblCentro2.Text = "El monto ingresado excede el saldo de su cuenta";
            lblCentro3.Text = "";
            lblCentro4.Text = "";
            lblCuenta.Text = "";
            lblClave.Text = "";
            lblIzq1.Text = "";
            lblIzq2.Text = "";
            lblIzq3.Text = "";
            lblIzq4.Text = "Salir";
            lblDer1.Text = "";
            lblDer2.Text = "";
            lblDer3.Text = "";            
            lblDer4.Text = "Otra Transacción";
        }
        public void cargaPanelMontoTransferencia()
        {
            lblBienvenido.Text = "Bienvenido Sr(a). " + servicio.buscaCliente(dni).getNombre() + " " + servicio.buscaCliente(dni).getapellidoPaterno();
            lblCentro1.Text = "Ingrese el monto de su cuenta a transferir";
            lblCentro2.Text = "______";
            lblCentro3.Text = "";
            lblCentro4.Text = "";
            lblCuenta.Text = "";
            lblClave.Text = "";
            lblIzq1.Text = "";
            lblIzq2.Text = "";
            lblIzq3.Text = "";
            lblIzq4.Text = "";
            lblDer1.Text = "";
            lblDer2.Text = "";
            lblDer3.Text = "";
            lblDer4.Text = "";
        }
        public void cargaPanelCuentaTransferenciaInvalida()
        {
            lblBienvenido.Text = "";
            lblCentro1.Text = "";
            lblCentro2.Text = "La cuenta ingresada no es valida";
            lblCentro3.Text = "";
            lblCentro4.Text = "";
            lblCuenta.Text = "";
            lblClave.Text = "";
            lblIzq1.Text = "";
            lblIzq2.Text = "";
            lblIzq3.Text = "";
            lblIzq4.Text = "Salir";
            lblDer1.Text = "";
            lblDer2.Text = "";
            lblDer3.Text = "";
            lblDer4.Text = "Otra Transacción";
        }
        public void cargaPanelRetiroValido()
        {
            lblBienvenido.Text = "";
            lblCentro1.Text = "";
            lblCentro2.Text = "Ud. ha retirado " + strMontoRetiro + " "+ servicio.buscaCuenta(numeroCuenta).getMoneda() + " de su cuenta";
            lblCentro3.Text = "";
            lblCentro4.Text = "";
            lblCuenta.Text = "";
            lblClave.Text = "";
            lblIzq1.Text = "";
            lblIzq2.Text = "";
            lblIzq3.Text = "";
            lblIzq4.Text = "Salir";
            lblDer1.Text = "";
            lblDer2.Text = "";
            lblDer3.Text = "";
            lblDer4.Text = "Otra Transacción";
        }
        public void cargaPanelMontoTransferenciaValido()
        {
            lblBienvenido.Text = "";
            lblCentro1.Text = "";
            lblCentro2.Text = "Ud. ha retirado " + strMontoTransferencia + " " + servicio.buscaCuenta(numeroCuenta).getMoneda() + " de su cuenta";
            lblCentro3.Text = "";
            lblCentro4.Text = "";
            lblCuenta.Text = "";
            lblClave.Text = "";
            lblIzq1.Text = "";
            lblIzq2.Text = "";
            lblIzq3.Text = "";
            lblIzq4.Text = "Salir";
            lblDer1.Text = "";
            lblDer2.Text = "";
            lblDer3.Text = "";
            lblDer4.Text = "Otra Transacción";
        }
        public void cargaPanelPagoAguaValido()
        {
            lblBienvenido.Text = "";
            lblCentro1.Text = "";
            lblCentro2.Text = "Ud. ha pagado " + strMontoPagoAgua + " " + servicio.buscaCuenta(numeroCuenta).getMoneda();
            lblCentro3.Text = "al servicio de agua";
            lblCentro4.Text = "";
            lblCuenta.Text = "";
            lblClave.Text = "";
            lblIzq1.Text = "";
            lblIzq2.Text = "";
            lblIzq3.Text = "";
            lblIzq4.Text = "Salir";
            lblDer1.Text = "";
            lblDer2.Text = "";
            lblDer3.Text = "";
            lblDer4.Text = "Otra Transacción";
        }
        public void cargaPanelSaldo()
        {
            dni = servicio.buscaCuenta(numeroCuenta).getDni();
            lblBienvenido.Text = "Bienvenido Sr(a). " + servicio.buscaCliente(dni).getNombre() + " " + servicio.buscaCliente(dni).getapellidoPaterno() + " " + servicio.buscaCliente(dni).getapellidoMaterno();
            lblCentro1.Text = "Su DNI es " + dni.ToString() + " y su numero de cuenta " + numeroCuenta + " tiene";            
            lblCentro2.Text = " " + servicio.buscaCuenta(numeroCuenta).getSaldo() + " " + servicio.buscaCuenta(numeroCuenta).getMoneda() + " disponibles";
            lblCentro3.Text = "";
            lblCentro4.Text = "";
            lblCuenta.Text = "";
            lblClave.Text = "";
            lblIzq1.Text = "";
            lblIzq2.Text = "";
            lblIzq3.Text = "";
            lblIzq4.Text = "Salir";
            lblDer1.Text = "";
            lblDer2.Text = "";
            lblDer3.Text = "";
            lblDer4.Text = "Otra Transacción";
        }
        public void cargaPanelPagos()
        {
            lblBienvenido.Text = "Bienvenido Sr(a). " + servicio.buscaCliente(dni).getNombre() + " " + servicio.buscaCliente(dni).getapellidoPaterno();
            lblCentro1.Text = "Seleccione el servicio a pagar";
            lblCentro2.Text = "";
            lblCentro3.Text = "";
            lblCentro4.Text = "";
            lblCuenta.Text = "";
            lblClave.Text = "";
            lblIzq1.Text = "";
            lblIzq2.Text = "Agua";
            lblIzq3.Text = "";
            lblIzq4.Text = "";
            lblDer1.Text = "";
            lblDer2.Text = "";
            lblDer3.Text = "";
            lblDer4.Text = "";
        }
        public void cargaPanelPagoAgua()
        {
            lblBienvenido.Text = "Bienvenido Sr(a). " + servicio.buscaCliente(dni).getNombre() + " " + servicio.buscaCliente(dni).getapellidoPaterno();
            lblCentro1.Text = "Ingrese el monto del pago";
            lblCentro2.Text = "______";
            lblCentro3.Text = "";
            lblCentro4.Text = "";
            lblCuenta.Text = "";
            lblClave.Text = "";
            lblIzq1.Text = "";
            lblIzq2.Text = "";
            lblIzq3.Text = "";
            lblIzq4.Text = "";
            lblDer1.Text = "";
            lblDer2.Text = "";
            lblDer3.Text = "";
            lblDer4.Text = "";
        }
        public void cargarPanelTranferencia()
        {
            lblBienvenido.Text = "Bienvenido Sr(a). " + servicio.buscaCliente(dni).getNombre() + " " + servicio.buscaCliente(dni).getapellidoPaterno();
            lblCentro1.Text = "Ingrese el numero de cuenta destinataria de la transferencia";
            lblCentro2.Text = "______";
            lblCentro3.Text = "";
            lblCentro4.Text = "";
            lblCuenta.Text = "";
            lblClave.Text = "";
            lblIzq1.Text = "";
            lblIzq2.Text = "";
            lblIzq3.Text = "";
            lblIzq4.Text = "";
            lblDer1.Text = "";
            lblDer2.Text = "";
            lblDer3.Text = "";
            lblDer4.Text = "";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (flagLoginCuenta == 1)
            {
                strCuenta = strCuenta + "1";
                lblCentro3.Text = strCuenta;
                return;
            }
            if (flagCuentaMontoTransferencia == 1)
            {
                strMontoTransferencia = strMontoTransferencia + "1";
                lblCentro2.Text = strMontoTransferencia;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "1";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
            if (flagMontoDeposito == 1)
            {
                strMontoDeposito = strMontoDeposito + "1";
                lblCentro2.Text = strMontoDeposito;
                return;
            }
            if (flagRetiro == 1)
            {
                strMontoRetiro = strMontoRetiro + "1";
                lblCentro2.Text = strMontoRetiro;
                return;
            }
            if (flagPagoAgua == 1)
            {
                strMontoPagoAgua = strMontoPagoAgua + "1";
                lblCentro2.Text = strMontoPagoAgua;
                return;
            }
            if (flagTransferencia == 1)
            {
                strCuentaTranferencia = strCuentaTranferencia + "1";
                lblCentro2.Text = strCuentaTranferencia;
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
            if (flagCuentaMontoTransferencia == 1)
            {
                strMontoTransferencia = strMontoTransferencia + "2";
                lblCentro2.Text = strMontoTransferencia;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "2";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
            if (flagMontoDeposito == 1)
            {
                strMontoDeposito = strMontoDeposito + "2";
                lblCentro2.Text = strMontoDeposito;
                return;
            }
            if (flagRetiro == 1)
            {
                strMontoRetiro = strMontoRetiro + "2";
                lblCentro2.Text = strMontoRetiro;
                return;
            }
            if (flagPagoAgua == 1)
            {
                strMontoPagoAgua = strMontoPagoAgua + "2";
                lblCentro2.Text = strMontoPagoAgua;
                return;
            }
            if (flagTransferencia == 1)
            {
                strCuentaTranferencia = strCuentaTranferencia + "2";
                lblCentro2.Text = strCuentaTranferencia;
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
            if (flagCuentaMontoTransferencia == 1)
            {
                strMontoTransferencia = strMontoTransferencia + "3";
                lblCentro2.Text = strMontoTransferencia;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "3";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
            if (flagMontoDeposito == 1)
            {
                strMontoDeposito = strMontoDeposito + "3";
                lblCentro2.Text = strMontoDeposito;
                return;
            }
            if (flagRetiro == 1)
            {
                strMontoRetiro = strMontoRetiro + "3";
                lblCentro2.Text = strMontoRetiro;
                return;
            }
            if (flagPagoAgua == 1)
            {
                strMontoPagoAgua = strMontoPagoAgua + "3";
                lblCentro2.Text = strMontoPagoAgua;
                return;
            }
            if (flagTransferencia == 1)
            {
                strCuentaTranferencia = strCuentaTranferencia + "3";
                lblCentro2.Text = strCuentaTranferencia;
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
            if (flagCuentaMontoTransferencia == 1)
            {
                strMontoTransferencia = strMontoTransferencia + "4";
                lblCentro2.Text = strMontoTransferencia;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "4";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
            if (flagMontoDeposito == 1)
            {
                strMontoDeposito = strMontoDeposito + "4";
                lblCentro2.Text = strMontoDeposito;
                return;
            }
            if (flagRetiro == 1)
            {
                strMontoRetiro = strMontoRetiro + "4";
                lblCentro2.Text = strMontoRetiro;
                return;
            }
            if (flagPagoAgua == 1)
            {
                strMontoPagoAgua = strMontoPagoAgua + "4";
                lblCentro2.Text = strMontoPagoAgua;
                return;
            }
            if (flagTransferencia == 1)
            {
                strCuentaTranferencia = strCuentaTranferencia + "4";
                lblCentro2.Text = strCuentaTranferencia;
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
            if (flagCuentaMontoTransferencia == 1)
            {
                strMontoTransferencia = strMontoTransferencia + "5";
                lblCentro2.Text = strMontoTransferencia;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "5";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
            if (flagMontoDeposito == 1)
            {
                strMontoDeposito = strMontoDeposito + "5";
                lblCentro2.Text = strMontoDeposito;
                return;
            }
            if (flagRetiro == 1)
            {
                strMontoRetiro = strMontoRetiro + "5";
                lblCentro2.Text = strMontoRetiro;
                return;
            }
            if (flagPagoAgua == 1)
            {
                strMontoPagoAgua = strMontoPagoAgua + "5";
                lblCentro2.Text = strMontoPagoAgua;
                return;
            }
            if (flagTransferencia == 1)
            {
                strCuentaTranferencia = strCuentaTranferencia + "5";
                lblCentro2.Text = strCuentaTranferencia;
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
            if (flagCuentaMontoTransferencia == 1)
            {
                strMontoTransferencia = strMontoTransferencia + "6";
                lblCentro2.Text = strMontoTransferencia;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "6";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
            if (flagMontoDeposito == 1)
            {
                strMontoDeposito = strMontoDeposito + "6";
                lblCentro2.Text = strMontoDeposito;
                return;
            }
            if (flagRetiro == 1)
            {
                strMontoRetiro = strMontoRetiro + "6";
                lblCentro2.Text = strMontoRetiro;
                return;
            }
            if (flagPagoAgua == 1)
            {
                strMontoPagoAgua = strMontoPagoAgua + "6";
                lblCentro2.Text = strMontoPagoAgua;
                return;
            }
            if (flagTransferencia == 1)
            {
                strCuentaTranferencia = strCuentaTranferencia + "6";
                lblCentro2.Text = strCuentaTranferencia;
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
            if (flagCuentaMontoTransferencia == 1)
            {
                strMontoTransferencia = strMontoTransferencia + "7";
                lblCentro2.Text = strMontoTransferencia;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "7";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
            if (flagMontoDeposito == 1)
            {
                strMontoDeposito = strMontoDeposito + "7";
                lblCentro2.Text = strMontoDeposito;
                return;
            }
            if (flagRetiro == 1)
            {
                strMontoRetiro = strMontoRetiro + "7";
                lblCentro2.Text = strMontoRetiro;
                return;
            }
            if (flagPagoAgua == 1)
            {
                strMontoPagoAgua = strMontoPagoAgua + "7";
                lblCentro2.Text = strMontoPagoAgua;
                return;
            }
            if (flagTransferencia == 1)
            {
                strCuentaTranferencia = strCuentaTranferencia + "7";
                lblCentro2.Text = strCuentaTranferencia;
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
            if (flagCuentaMontoTransferencia == 1)
            {
                strMontoTransferencia = strMontoTransferencia + "8";
                lblCentro2.Text = strMontoTransferencia;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "8";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
            if (flagMontoDeposito == 1)
            {
                strMontoDeposito = strMontoDeposito + "8";
                lblCentro2.Text = strMontoDeposito;
                return;
            }
            if (flagRetiro == 1)
            {
                strMontoRetiro = strMontoRetiro + "8";
                lblCentro2.Text = strMontoRetiro;
                return;
            }
            if (flagPagoAgua == 1)
            {
                strMontoPagoAgua = strMontoPagoAgua + "8";
                lblCentro2.Text = strMontoPagoAgua;
                return;
            }
            if (flagTransferencia == 1)
            {
                strCuentaTranferencia = strCuentaTranferencia + "8";
                lblCentro2.Text = strCuentaTranferencia;
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
            if (flagCuentaMontoTransferencia == 1)
            {
                strMontoTransferencia = strMontoTransferencia + "9";
                lblCentro2.Text = strMontoTransferencia;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "9";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
            if (flagMontoDeposito == 1)
            {
                strMontoDeposito = strMontoDeposito + "9";
                lblCentro2.Text = strMontoDeposito;
                return;
            }
            if (flagRetiro == 1)
            {
                strMontoRetiro = strMontoRetiro + "9";
                lblCentro2.Text = strMontoRetiro;
                return;
            }
            if (flagPagoAgua == 1)
            {
                strMontoPagoAgua = strMontoPagoAgua + "9";
                lblCentro2.Text = strMontoPagoAgua;
                return;
            }
            if (flagTransferencia == 1)
            {
                strCuentaTranferencia = strCuentaTranferencia + "9";
                lblCentro2.Text = strCuentaTranferencia;
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
            if (flagCuentaMontoTransferencia == 1)
            {
                strMontoTransferencia = strMontoTransferencia + "0";
                lblCentro2.Text = strMontoTransferencia;
                return;
            }
            if (flagLoginClave == 1)
            {
                strClave = strClave + "0";
                strClaveX = strClaveX + "*";
                lblCentro4.Text = strClaveX;
                return;
            }
            if (flagMontoDeposito == 1)
            {
                strMontoDeposito = strMontoDeposito + "0";
                lblCentro2.Text = strMontoDeposito;
                return;
            }
            if (flagRetiro == 1)
            {
                strMontoRetiro = strMontoRetiro + "0";
                lblCentro2.Text = strMontoRetiro;
                return;
            }
            if (flagPagoAgua == 1)
            {
                strMontoPagoAgua = strMontoPagoAgua + "0";
                lblCentro2.Text = strMontoPagoAgua;
                return;
            }
            if (flagTransferencia == 1)
            {
                strCuentaTranferencia = strCuentaTranferencia + "0";
                lblCentro2.Text = strCuentaTranferencia;
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
            if (flagMontoDeposito == 1)
            {
                cargaPanelDeposito();                
                strMontoDeposito = "";                
                return;
            }
            if (flagRetiro == 1)
            {
                cargaPanelRetiro();
                strMontoRetiro = "";
                return;
            }
            if (flagPagoAgua == 1)
            {
                cargaPanelPagoAgua();
                strMontoPagoAgua = "";
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
                numeroCuenta = servicio.convierteNumero(strCuenta);
                clave = servicio.convierteNumero(strClave);
                if (servicio.validarCuenta(numeroCuenta, clave))
                {
                    flagLoginCuenta = 0;
                    flagLoginClave = 0;
                    flagOpciones = 1;
                    cargaPanelOpciones();
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
                    strClave = "";
                    strClaveX = "";
                    cargaPanelLoginInvalido();
                }
                return;
            }
            if (flagMontoDeposito == 1)
            {
                flagMontoDeposito = 0;
                saldo = servicio.buscaCuenta(numeroCuenta).getSaldo();
                saldo = saldo + servicio.convierteNumero(strMontoDeposito);
                servicio.buscaCuenta(numeroCuenta).setSaldo(saldo);
                cargaPanelMensajeDeposito();
                strMontoDeposito = "";
                flagMensajeMontoDeposito = 1;
                return;
            }
            if (flagRetiro == 1)
            {
                flagRetiro = 0;
                saldo = servicio.buscaCuenta(numeroCuenta).getSaldo();
                saldo = saldo - servicio.convierteNumero(strMontoRetiro);
                if (saldo < 0)
                {
                    cargaPanelRetiroInvalido();
                    strMontoRetiro = "";
                }
                else
                {
                    servicio.buscaCuenta(numeroCuenta).setSaldo(saldo);
                    cargaPanelRetiroValido();
                    strMontoRetiro = "";
                }
                flagMensajeRetiro = 1;
                return;
            }
            if (flagPagoAgua == 1)
            {
                flagPagoAgua = 0;
                saldo = servicio.buscaCuenta(numeroCuenta).getSaldo();
                saldo = saldo - servicio.convierteNumero(strMontoPagoAgua);
                if (saldo < 0)
                {
                    cargaPanelRetiroInvalido();
                    strMontoPagoAgua = "";
                }
                else
                {
                    servicio.buscaCuenta(numeroCuenta).setSaldo(saldo);
                    cargaPanelPagoAguaValido();
                    strMontoPagoAgua = "";
                }
                flagMensajePagoAgua = 1;
                return;
            }
            if (flagTransferencia == 1)
            {
                flagTransferencia = 0;
                cuentaTransferencia = servicio.convierteNumero(strCuentaTranferencia);
                Cuenta c = servicio.buscaCuenta(cuentaTransferencia);                
                if (c == null)
                {
                    flagCuentaTransferenciaInvalida = 1;
                    cargaPanelCuentaTransferenciaInvalida();
                    return;
                }
                else
                {
                    flagCuentaMontoTransferencia = 1;
                    cargaPanelMontoTransferencia();
                    return;
                }
            }
            if (flagCuentaMontoTransferencia == 1)
            {
                flagCuentaMontoTransferencia = 0;
                montoTransferencia = servicio.convierteNumero(strMontoTransferencia);

                saldoTransferencia = servicio.buscaCuenta(cuentaTransferencia).getSaldo();
                saldo = servicio.buscaCuenta(numeroCuenta).getSaldo();
                moneda = servicio.buscaCuenta(numeroCuenta).getMoneda();
                monedaTranferencia = servicio.buscaCuenta(cuentaTransferencia).getMoneda();

                if (moneda.Equals("soles"))
                {
                    if (monedaTranferencia.Equals("dolares"))
                    {
                        saldoTransferencia = saldoTransferencia / 2.5f;      
                        saldo = saldo - montoTransferencia;
                        saldoTransferencia = saldoTransferencia + montoTransferencia;                        
                    }
                }
                if (moneda.Equals("dolares"))
                {
                    if (monedaTranferencia.Equals("soles"))
                    {
                        saldoTransferencia = saldoTransferencia * 2.5f;
                        saldo = saldo - montoTransferencia;
                        saldoTransferencia = saldoTransferencia + montoTransferencia;
                    }
                }                

                if (saldo < 0)
                {
                    cargaPanelRetiroInvalido();
                    strMontoTransferencia = "";
                }
                else
                {
                    servicio.buscaCuenta(numeroCuenta).setSaldo(saldo);                    
                    servicio.buscaCuenta(cuentaTransferencia).setSaldo(saldoTransferencia);
                    cargaPanelMontoTransferenciaValido();
                    strMontoTransferencia = "";
                }
                flagMensajeTranferencia = 1;
            }
        }

        private void btnIzq2_Click(object sender, EventArgs e)
        {           
            if (flagOpciones == 1)
            {
                flagOpciones = 0;                
                flagMontoDeposito = 1;
                cargaPanelDeposito();                
                return;
            }
            if (flagPagos == 1)
            {
                flagPagos = 0;
                flagPagoAgua = 1;
                cargaPanelPagoAgua();
                return;
            }
        }
        private void btnDer4_Click(object sender, EventArgs e)
        {            
            if (flagMensajeMontoDeposito == 1)
            {
                flagMensajeMontoDeposito = 0;                
                flagLoginCuenta = 0;
                flagLoginClave = 0;
                flagOpciones = 1;                
                cargaPanelOpciones();
                return;
            }
            if (flagMensajeTranferencia == 1)
            {
                flagMensajeTranferencia = 0;
                flagLoginCuenta = 0;
                flagLoginClave = 0;
                flagOpciones = 1;
                cargaPanelOpciones();
                return;
            }
            if (flagMensajeRetiro== 1)
            {
                flagMensajeRetiro = 0;
                flagLoginCuenta = 0;
                flagLoginClave = 0;
                flagOpciones = 1;
                cargaPanelOpciones();
                return;
            }
            if (flagMensajePagoAgua == 1)
            {
                flagMensajePagoAgua = 0;
                flagLoginCuenta = 0;
                flagLoginClave = 0;
                flagOpciones = 1;
                cargaPanelOpciones();
                return;
            }
            if (flagSaldo== 1)
            {
                flagSaldo= 0;
                flagLoginCuenta = 0;
                flagLoginClave = 0;
                flagOpciones = 1;
                cargaPanelOpciones();
                return;
            }
            if (flagOpciones == 1)
            {
                flagOpciones = 0;
                flagLoginCuenta = 1;
                numeroCuenta = 0;
                clave = 0;
                dni = 0;
                strClave = "";
                strClaveX = "";
                strCuenta = "";
                cargaPanelLogin();
                return;
            }
            if (flagCuentaTransferenciaInvalida == 1)
            {
                flagCuentaTransferenciaInvalida = 0;
                flagLoginCuenta = 0;
                flagLoginClave = 0;
                flagOpciones = 1;
                cargaPanelOpciones();
                return;
            }
        }
        private void btnIzq4_Click(object sender, EventArgs e)
        {
            if (flagMensajeMontoDeposito == 1)
            {
                flagMensajeMontoDeposito = 0;
                flagLoginCuenta = 1;
                numeroCuenta = 0;
                clave = 0;
                dni = 0;
                cuentaTransferencia = 0;
                strClave = "";
                strClaveX = "";
                strCuenta = "";
                strCuentaTranferencia = "";
                cargaPanelLogin();
                return;
            }
            if (flagMensajeTranferencia == 1)
            {
                flagMensajeTranferencia = 0;
                flagLoginCuenta = 1;
                numeroCuenta = 0;
                clave = 0;
                dni = 0;
                cuentaTransferencia = 0;
                strClave = "";
                strClaveX = "";
                strCuenta = "";
                strCuentaTranferencia = "";
                cargaPanelLogin();
                return;
            }
            if (flagMensajeRetiro == 1)
            {
                flagMensajeRetiro= 0;
                flagLoginCuenta = 1;
                numeroCuenta = 0;
                clave = 0;
                dni = 0;
                cuentaTransferencia = 0;
                strClave = "";
                strClaveX = "";
                strCuenta = "";
                strCuentaTranferencia = "";
                cargaPanelLogin();
                return;
            }
            if (flagMensajePagoAgua == 1)
            {
                flagMensajePagoAgua = 0;
                flagLoginCuenta = 1;
                numeroCuenta = 0;
                clave = 0;
                dni = 0;
                cuentaTransferencia = 0;
                strClave = "";
                strClaveX = "";
                strCuenta = "";
                strCuentaTranferencia = "";
                cargaPanelLogin();
                return;
            }
            if (flagSaldo== 1)
            {
                flagSaldo= 0;
                flagLoginCuenta = 1;
                numeroCuenta = 0;
                clave = 0;
                dni = 0;
                cuentaTransferencia = 0;
                strClave = "";
                strClaveX = "";
                strCuenta = "";
                strCuentaTranferencia = "";
                cargaPanelLogin();
                return;
            }
            if (flagCuentaTransferenciaInvalida == 1)
            {
                flagCuentaTransferenciaInvalida = 0;
                flagLoginCuenta = 1;
                numeroCuenta = 0;
                clave = 0;
                dni = 0;
                cuentaTransferencia = 0;
                strClave = "";
                strClaveX = "";
                strCuenta = "";
                strCuentaTranferencia = "";
                cargaPanelLogin();
                return;
            }
            if (flagOpciones == 1)
            {
                flagOpciones = 0;
                flagSaldo = 1;
                cargaPanelSaldo();
                return;
            }
        }
        private void btnDer2_Click(object sender, EventArgs e)
        {
            if (flagOpciones == 1)
            {
                flagOpciones = 0;
                flagRetiro = 1;
                cargaPanelRetiro();
                return;
            }
        }
        private void btnIzq3_Click(object sender, EventArgs e)
        {
            if (flagOpciones == 1)
            {
                flagOpciones = 0;
                flagPagos = 1;
                cargaPanelPagos();
                return;
            }
        }

        private void VentanaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {            
            this.Dispose();
            bienvenida.Show();
        }

        private void btnDer3_Click(object sender, EventArgs e)
        {
            if (flagOpciones == 1)
            {
                flagOpciones = 0;
                flagTransferencia = 1;
                cargarPanelTranferencia();
                return;
            }
        }
    }
}
