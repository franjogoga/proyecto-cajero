using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Libreria;

namespace Servicios
{
    public class Servicio
    {
        List<Usuario> usuarios = new List<Usuario>();
        List<Cuenta> cuentas = new List<Cuenta>();
        List<Cliente> clientes = new List<Cliente>();

        public List<Usuario> cargarUsuarios()
        {                        
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
            Cuenta c1 = new Cuenta();
            c1.setNumero(112233);
            c1.setDni(11111111);
            c1.setClave(1122);
            c1.setTipo("Ahorro");
            c1.setSaldo(200.8f);
            c1.setMoneda("soles");

            Cuenta c2= new Cuenta();
            c2.setNumero(112234);
            c2.setDni(11111111);
            c2.setClave(1123);
            c2.setTipo("Corriente");
            c2.setSaldo(500.1f);
            c2.setMoneda("soles");

            Cuenta c3 = new Cuenta();
            c3.setNumero(223344);
            c3.setDni(22222222);
            c3.setClave(2233);
            c3.setTipo("Ahorro");
            c3.setSaldo(5000.3f);
            c3.setMoneda("dolares");

            cuentas.Add(c1);
            cuentas.Add(c2);
            cuentas.Add(c3);

            return cuentas;
        }

        public List<Cliente> cargarClientes()
        {            
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

            clientes.Add(c1);
            clientes.Add(c2);

            return clientes;
        }

        public bool validarCuenta(int numeroCuenta, int clave)
        {            
            bool valido = false;
            Cuenta cuenta = buscaCuenta(numeroCuenta);
            if (cuenta == null)            
                valido = false;            
            else            
                if (clave == cuenta.getClave())
                    valido = true;
                else
                    valido = false;            
            return valido;
        }

        public int convierteNumero(string strNumero)
        {
            if (strNumero.Equals(""))
                return 0;
            else
                return int.Parse(strNumero);
        }        

        public Cuenta buscaCuenta(int numeroCuenta)
        {            
            Cuenta cuenta=null;
            foreach (Cuenta c in cuentas)            
                if (numeroCuenta == c.getNumero())                
                    cuenta = c;                            
            return cuenta;
        }

        public Cliente buscaCliente(int dniCliente)
        {
            Cliente cliente = null;
            foreach (Cliente c in clientes)
                if (dniCliente == c.getDni())
                    cliente = c;
            return cliente;
        }

        public List<Cuenta> consultaCuentaPorTipo(string tipo)
        {
            List<Cuenta> consulta = new List<Cuenta>();
            foreach (Cuenta c in cuentas)
            {        
                if ( c.getTipo().ToUpper().Equals( tipo.ToUpper() ) )
                    consulta.Add(c);                                               
            }
            return consulta;
        }

        public List<Cuenta> consultaCuentaPorMoneda(string tipo)
        {
            List<Cuenta> consulta = new List<Cuenta>();
            foreach (Cuenta c in cuentas)
            {
                if (c.getMoneda().ToUpper().Equals(tipo.ToUpper()))
                    consulta.Add(c);
            }
            return consulta;
        }
       

    }
}
