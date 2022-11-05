using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Scramble001
{
    class Program
    {
        static void Main(string[] args)
        {
            String respuesta = "FALSE";
            //se le pide al usuario que ingrese las 2 cadenas que se desean comparar
            Console.WriteLine("Introduzca la primera cadena");
            String cadena1;
            cadena1 = Console.ReadLine();
            Console.WriteLine("Introduzca la primera cadena");
            String cadena2;
            cadena2 = Console.ReadLine();
            //falso o verdadero
            bool abSame = !cadena1.Except(cadena2).Any() && !cadena2.Except(cadena1).Any();
            Console.WriteLine(abSame);//mostrar resultado

            Console.ReadKey ();
        }

    }
}
