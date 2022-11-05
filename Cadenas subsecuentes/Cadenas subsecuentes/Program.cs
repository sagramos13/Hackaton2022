using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas_subsecuentes
{
    class Program
    {
        static void Main(string[] args)
        {
            //se le pide al usuario que ingrese las 2 cadenas que se desean comparar
            Console.WriteLine("Introduzca la primera cadena");
            String cadena1;
            cadena1 = Console.ReadLine();
            Console.WriteLine("Introduzca la primera cadena");
            String cadena2;
            cadena2 = Console.ReadLine();

            //cadena no continua
            int numa = cadena1.Count();
            int numb = cadena2.Count();
            int runs = 0;
            StringBuilder sb = new StringBuilder();

            if (numa <= numb)
            {
                runs = numa;
            }
            else
            {
                runs = numb;
            }

            for (int i = 0; i < runs; i++)
            {
                if (cadena1[i] == cadena2[i])
                {
                    sb.Append(cadena1[i]);
                }
            }

            Console.WriteLine(sb.ToString());
            Console.ReadKey();

        }
    }
}
