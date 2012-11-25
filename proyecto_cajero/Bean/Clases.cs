using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    public class Usuario
    {        
        private int dni;
        private int clave;
        private string nombres;
        private string apellidoPaterno;
        private string apellidoMaterno;

        public Usuario() { }
        public void setDni(int dni)
        {
            this.dni = dni;
        }
        public int getDni()
        {
            return dni;
        }
        public void setClave(int clave)
        {
            this.clave = clave;
        }
        public int getClave()
        {
            return clave;
        }
        public void setNombres(string nombres)
        {
            this.nombres = nombres;
        }
        public string getNombres()
        {
            return nombres;
        }
        public void setApellidoPaterno(string apellidoPaterno)
        {
            this.apellidoPaterno = apellidoPaterno;
        }
        public string getApellidoPaterno()
        {
            return apellidoPaterno;
        }
        public void setApellidoMaterno(string apellidoMaterno)
        {
            this.apellidoMaterno = apellidoPaterno;
        }
        public string getApellidoMaterno()
        {
            return apellidoMaterno;
        }
    }

    public class Cuenta
    {

        private int numero;
        private int clave;
        private string tipo;

        public Cuenta() { }
        public void setNumero (int numero)
        {
            this.numero = numero;
        }
        public int getNumero()
        {
            return numero;
        }
        public void setClave (int clave)
        {
            this.clave = clave;
        }
        public int getClave()
        {
            return clave;
        }
        public void setTipo (string tipo)
        {
            this.tipo = tipo;
        }
        public string getTipo()
        {
            return tipo;
        }

    }

    public class Cliente
    {
        private int dni;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private List<Cuenta> cuentas = null;

        public Cliente() { }
        public void setDni (int dni)
        {
            this.dni = dni;
        }
        public int getDni()
        {
            return dni;
        }
        public void setNombre (string nombre)
        {
            this.nombre= nombre;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setApellidoPaterno (string apellidoPaterno)
        {
            this.apellidoPaterno = apellidoPaterno;
        }
        public string getapellidoPaterno()
        {
            return apellidoPaterno;
        }
        public void setapellidoMaterno ( string apellidoMaterno)
        {
            this.apellidoMaterno=apellidoMaterno;
        }
        public string getapellidoMaterno()
        {
            return apellidoMaterno;
        }
        public void setCuenta(List<Cuenta> cuentas)
        {
            this.cuentas = cuentas;
        }
        public List<Cuenta> getCuentas()
        {
            return cuentas;
        }

    }

}
