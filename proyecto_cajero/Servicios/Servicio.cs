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

        public List<Cuenta> cargarCuentas()
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            Cuenta c1 = new Cuenta();
            c1.setNumero(112233);
            c1.setDni(11111111);
            c1.setClave(1122);
            c1.setTipo("Ahorro");
            c1.setSaldo(200.8f);

            Cuenta c2= new Cuenta();
            c2.setNumero(112234);
            c2.setDni(11111111);
            c2.setClave(1123);
            c2.setTipo("Corriente");
            c2.setSaldo(500.1f);

            Cuenta c3 = new Cuenta();
            c3.setNumero(223344);
            c3.setDni(22222222);
            c3.setClave(2233);
            c3.setTipo("Ahorro");
            c3.setSaldo(50.3f);

            cuentas.Add(c1);
            cuentas.Add(c2);
            cuentas.Add(c3);

            return cuentas;
        }

        public List<Cliente> cargarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            Cliente c1 = new Cliente();
            c1.setDni(11111111);
            c1.setNombre("Pepito");
            c1.setApellidoPaterno("Alvarez");
            c1.setapellidoMaterno("Malpartida");                                    

            Cliente c2 = new Cliente();
            c2.setDni(22222222);
            c2.setNombre("Esteban");
            c2.setApellidoPaterno("Dido");
            c2.setapellidoMaterno("Mesa");                                   

            return clientes;
        }

        public bool validarCuenta(string strCuenta, string strClave)
        {
            bool valido = false;
            int cuenta;
            int clave;
            if (strCuenta.Equals(""))            
                cuenta = 0;            
            else
                cuenta = int.Parse(strCuenta);

            if (strClave.Equals(""))
                clave = 0;
            else
                clave = int.Parse(strClave);




            return valido;
        }
    }
}
