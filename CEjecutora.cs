using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club
{
    public class CEjecutora
    {
        public static void Main(string[] args)
        {
            int num_socio = 0, año_nac, contSocios = 0, contJuv = 0, contInf = 0, contAdu = 0, contVet = 0, edad;
            string apellido, nombre, cat;
            char sexo;
            float suma_edades = 0;
            CSocio soc_mayor = new CSocio();
            CSocio socio = new CSocio();

            Random rand = new Random();

            Console.WriteLine("Ingrese numero de socio: ");
            num_socio = int.Parse(Console.ReadLine());
            

            while (contSocios < 100000 && num_socio != -1)
            {
                Console.WriteLine("Nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Apellido: ");
                apellido = Console.ReadLine();
                Console.WriteLine("Año de nacimiento: ");
                año_nac = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Sexo: ");
                sexo = char.Parse(Console.ReadLine());

                edad = 2024  - año_nac;

                if (edad < 12)
                {
                    contInf++;
                }
                else if (edad < 18)
                {
                    contJuv++;
                }
                else if (edad < 65)
                {
                    contAdu++;
                }
                else
                {
                    contJuv++;
                }


                socio = new CSocio(num_socio, año_nac, nombre, apellido, sexo);


                if (contSocios == 0)
                {
                    soc_mayor = socio;
                }

                if (socio.GetAño() > soc_mayor.GetAño())
                {
                    soc_mayor = socio;
                }

                suma_edades += edad;

                contSocios++;

                Console.WriteLine("Ingrese numero de socio: ");
                num_socio = int.Parse(Console.ReadLine());
            }

            if(contSocios != 0)
            {
                Console.WriteLine("El promedio de edades es: {0}", suma_edades / contSocios);

                Console.WriteLine("El porcentaje de socios Infantiles es: {0}", (contInf / contSocios) * 100.0);
                Console.WriteLine("El porcentaje de socios Juveniles es: {0}", (contJuv / contSocios) * 100.0);
                Console.WriteLine("El porcentaje de socios Adultos es: {0}", (contAdu / contSocios) * 100.0);
                Console.WriteLine("El porcentaje de socios Veteranos es: {0}", (contVet / contSocios) * 100.0);

                Console.WriteLine("El socio mayor es {0}", soc_mayor.DarDatos());

            }

        }


       
        
    }
}
