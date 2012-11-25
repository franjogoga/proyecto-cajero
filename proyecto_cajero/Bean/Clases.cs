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



    }

    public class CLiente
    {


    }

}
