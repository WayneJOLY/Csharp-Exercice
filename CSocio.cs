using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club
{
    public class CSocio
    {
            private int num_socio, año_nac;
            private string apellido, nombre;
            private char sexo;

            public CSocio()
            {
                this.num_socio = num_socio;
                this.año_nac = año_nac;
                this.apellido = apellido;
                this.nombre = nombre;
                this.sexo = sexo;
            }

        public CSocio(int num_socio, int año_nac, string apellido, string nombre, char sexo)
        {
            this.num_socio = num_socio;
            this.año_nac = año_nac;
            this.apellido = apellido;
            this.nombre = nombre;
            this.sexo = sexo;
        }

        public int GetAño() { return this.año_nac; }

        public string DarDatos()
            {
                string datos = "Nro de Socio:" + this.num_socio + "Nombre: " + this.nombre;
                datos += "Apellido: " + this.apellido + "Año de nacimiento: " + this.año_nac;
                datos += "Sexo: " + this.sexo;
                return datos;
            }
        
    }
}
