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
        public VentanaCliente()
        {
            InitializeComponent();
            clientes = servicio.cargarClientes();
        }



    }
}
