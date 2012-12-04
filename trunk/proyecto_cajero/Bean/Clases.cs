using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    public class Cuenta
    {
        private int numero;
        private int dni;
        private int clave;
        private string tipo;
        private string moneda;
        private float saldo;

        public Cuenta() { }
        public void setNumero (int numero)
        {
            this.numero = numero;
        }
        public int getNumero()
        {
            return numero;
        }
        public void setDni(int dni)
        {
            this.dni = dni;
        }
        public int getDni()
        {
            return dni;
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
        public void setMoneda(string moneda)
        {
            this.moneda = moneda;
        }
        public string getMoneda()
        {
            return moneda;
        }
        public void setSaldo(float saldo)
        {
            this.saldo = saldo;
        }
        public float getSaldo()
        {
            return saldo;
        }
    }

    public class Cliente
    {
        private int dni;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;        

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
    }
}
