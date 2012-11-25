using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Libreria;

namespace Servicios
{
    public class Servicio
    {

        public List<Usuario> cargarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            
            Usuario u1 = new Usuario();
            u1.setDni(12345678);
            u1.setClave(1234);
            u1.setNombres("Juan");
            u1.setApellidoPaterno("Perez");
            u1.setApellidoMaterno("Garcia");

            Usuario u2 = new Usuario();
            u1.setDni(87654321);
            u1.setClave(4321);
            u1.setNombres("Juana");
            u1.setApellidoPaterno("Pereza");
            u1.setApellidoMaterno("Gracia");

            usuarios.Add(u1);
            usuarios.Add(u2);
            return usuarios;
        }

        public List<Cliente> cargarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            Cliente c1 = new Cliente();
            c1.setDni(11111111);
            c1.setNombre("Pepito");
            c1.setApellidoPaterno("Alvarez");
            c1.setapellidoMaterno("Malpartida");

            List<Cuenta> cuentaC1 = new List<Cuenta>();
            Cuenta cuenta1C1 = new Cuenta();
            cuenta1C1.setNumero(112233);
            cuenta1C1.setClave(1122);
            cuenta1C1.setTipo("Ahorro");

            Cuenta cuenta2C1 = new Cuenta();
            cuenta2C1.setNumero(112234);
            cuenta2C1.setClave(1123);
            cuenta2C1.setTipo("Corriente");

            cuentaC1.Add(cuenta1C1);
            cuentaC1.Add(cuenta2C1);

            c1.setCuenta(cuentaC1);

            Cliente c2 = new Cliente();
            c2.setDni(22222222);
            c2.setNombre("Esteban");
            c2.setApellidoPaterno("Dido");
            c2.setapellidoMaterno("Mesa");

            List<Cuenta> cuentaC2 = new List<Cuenta>();
            Cuenta cuenta1C2 = new Cuenta();
            cuenta1C2.setNumero(223344);
            cuenta1C2.setClave(2233);
            cuenta1C2.setTipo("Ahorro");

            cuentaC2.Add(cuenta1C2);

            c1.setCuenta(cuentaC2);

            return clientes;
        }
    }
}
