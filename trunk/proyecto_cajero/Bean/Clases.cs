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
        public string getNombres()
        {
            return nombres;
        }
    }

    public class Cuenta
    {

     private int numero;
     private int clave;
     private string tipo;
     
        public void setnumero (int numero)
        {
            this.numero = numero;
        }
        public int getnumero()
        {
            return numero;
        }
        public void setclave (int clave)
        {
            this.clave = clave;
        }
        public int getclave()
        {
            return clave;
        }
        public void settipo (string tipo)
        {
            this.tipo = tipo;
        }
        public string gettipo()
        {
            return tipo;
        }

    }

    public class CLiente
    {
        private int dni;
        private int nombre;
        private string apellido;
        private string apellidoPaterno;

        public void setdni (int dni)
        {
            this.dni = dni;
        }
        public int getdni()
        {
            return dni;
        }
        public void setnombre (int nombre)
        {
            this.nombre= nombre;
        }
        public int getnombre()
        {
            return nombre;
        }
        public void setapellido (string apellido)
        {
            this.apellido = apellido;
        }
        public string getapellido()
        {
            return apellido;
        }
        public void setapellidoPaterno ( string apellidoPaterno)
        {
            this.apellidoPaterno=apellidoPaterno;
        }
        public string getapellidoPaterno()
        {
            return apellidoPaterno;
        }


    }

}
