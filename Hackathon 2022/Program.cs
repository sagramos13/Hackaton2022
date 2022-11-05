using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
        Menu1();
    }

    static void Menu1()
    {
        // Tengo un booleano que, en caso en el que la tecla asignada enter se "active" pase ser true
        bool ejecutar = false;
        //mi ciclo de ejecución continua en el que sumara o restara valores en las teclas
        for (int a = 0; ;)
        {
            //se ejecuta el método para pintar el menú
            PintaMenu(a);
            //me permite mandar información del teclado cuando x tecla se active
            ConsoleKeyInfo key = Console.ReadKey(true);
            /* En caso en que x tecla se presione sumara o restara valores 
            (en caso de ejecutar las teclas arriba y abajo)
            Para  navegar en el mapa*/
            switch (key.Key)
            {
                case ConsoleKey.UpArrow: a--; Console.Beep(); break;
                case ConsoleKey.DownArrow: a++; Console.Beep(784, 125); break;
                case ConsoleKey.Enter: ejecutar = true; Console.Beep(); break;
            }
            /*Esto limita el valor de las teclas en caso de obtener valores por encima o debajo de la cantidad de
            "botones" que tengo*/
            if (a < 0) a = 4;

            if (a > 4) a = 0;
            /*Esto restringe solamente en caso de que ejecutar se active*/

            if (ejecutar)
            {
                //aquí vuelve a poner el estado de ejecutar en falso 
                ejecutar = false;
                //a es el valor de mis teclas que, en caso de que a sea 0 ejecute x acción o en caso sea 1 otra 
                switch (a)
                {

                    case 0:
                        {
                            Console.Beep();
                            Console.Clear();
                            Console.SetCursorPosition(0, 3);

                            //se le pide al usuario que ingrese las 2 cadenas que se desean comparar no importa si es en mayusculas o minusculas
                            Console.WriteLine("Introduzca la primera cadena");
                            String cadena1;
                            cadena1 = Console.ReadLine();
                            Console.WriteLine("Introduzca la segunda cadena");
                            String cadena2;
                            cadena2 = Console.ReadLine();
                            //falso o verdadero
                            cadena1 = cadena1.ToUpper();
                            cadena2 = cadena2.ToUpper();
                            bool abSame = !cadena1.Except(cadena2).Any() && !cadena2.Except(cadena1).Any();
                            Console.WriteLine(abSame);//mostrar resultado
                            Console.WriteLine("Presione una tecla para continuar");
                            Console.ReadKey();


                            break;


                        }
                    case 1:

                        {
                            break;
                        }

                    case 2:
                        {
                            Console.Beep();
                            Console.Clear();
                            Console.SetCursorPosition(0, 3);

                            //se le pide al usuario que ingrese las 2 cadenas que se desean comparar
                            Console.WriteLine("Introduzca la primera cadena");
                            String cadena1;
                            cadena1 = Console.ReadLine();
                            Console.WriteLine("Introduzca la segunda cadena");
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






                            break;

                        }
                        
                        break;


                    case 3:

                        {
                            Console.Beep();
                            Console.Clear();
                            Console.SetCursorPosition(0, 3);

                            Console.WriteLine("Introduzca el primer numero");
                            int n1 = 0;
                            n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Introduzca el segundo numero");
                            int n2 = 0;
                            n2 = int.Parse(Console.ReadLine());


                            string totalBinario = ToBin(n1 + n2, 8);
                            var count = totalBinario.Count(ch => ch == '1');

                            Console.WriteLine("La abuela le dara:" +count+" avellanas");
                            Console.ReadLine();
                            Opcion1(); break;
                            
                        }
                    case 4:
                        {
                            //esto me permite limpiar la pantalla de la consola
                            Console.Beep();
                            Console.Clear();
                            Console.SetCursorPosition(1, 8);
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("******BUEN DIA******".Length / 2)) + "}", "******BUEN DIA******"));
                            /*Reemplaza la necesidad de usar la consola para mantener un mensaje en vista donde
                              Lo que está en () es el tiempo en milisegundos  */
                            Thread.Sleep(1800);
                        }
                        return;

                }
            }
        }
    }
    //lo mismo que la función anterior

    public static string ToBin(int value, int len)
    {
        return (len > 1 ? ToBin(value >> 1, len - 1) : null) + "01"[value & 1];
    }
    static void Menu2()
    {
        bool ejecutar = false;
        for (int a = 0; ;)
        {
            Volvermenu(a);
            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.UpArrow: a--; break;
                case ConsoleKey.DownArrow: a++; break;
                case ConsoleKey.Enter: ejecutar = true; break;
            }

            if (a < 0) a = 4;

            if (a > 4) a = 0;

            if (ejecutar)
            {
                ejecutar = false;
                switch (a)
                {
                    case 0:
                        {
                            Console.Beep();
                            Console.Clear();
                            Console.SetCursorPosition(1, 8);


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




                            Opcion1(); break;




                        }
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4:
                        {


                            Console.Beep();
                            Console.Clear();
                            Console.SetCursorPosition(1, 8);
                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("******GRACIAS POR JUGAR******".Length / 2)) + "}", "******BUEN DIA******"));
                            Thread.Sleep(1800);
                        }
                        return;

                }
            }
        }
    }
    //funcion que pinta el menú 
    static void PintaMenu(int a)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        ConsoleColor ca = ConsoleColor.DarkBlue;
        ConsoleColor sea = ConsoleColor.Red;
        Console.SetCursorPosition(11, 5);
        Console.ForegroundColor = ca;
        Console.WriteLine("┌─────────────────────────────────────────────────────────┐");
        Console.SetCursorPosition(11, 6);
        Console.WriteLine("│                                                         │");
        //esto me indica que, en caso de que a sea 1 de x color pasara a y color
        Console.ForegroundColor = a == 0 ? sea : ca;
        Console.SetCursorPosition(11, 7);
        Console.WriteLine("│                   Primer Problema                       │");
        Console.SetCursorPosition(11, 8);
        Console.ForegroundColor = ca;
        Console.WriteLine("│                                                         │");
        Console.SetCursorPosition(11, 9);
        Console.WriteLine("│                                                         │");
        Console.ForegroundColor = a == 1 ? sea : ca;
        Console.SetCursorPosition(11, 10);
        Console.WriteLine("│                   Segundo Problema                      │");
        Console.SetCursorPosition(11, 11);
        Console.ForegroundColor = ca;
        Console.WriteLine("│                                                         │");
        Console.SetCursorPosition(11, 12);
        Console.WriteLine("│                                                         │");
        Console.ForegroundColor = ca;
        Console.ForegroundColor = a == 2 ? sea : ca;
        Console.SetCursorPosition(11, 13);
        Console.WriteLine("│                   Tercer Problema                       │");
        Console.SetCursorPosition(11, 14);
        Console.ForegroundColor = ca;
        Console.WriteLine("│                                                         │");

        Console.SetCursorPosition(11, 15);
        Console.WriteLine("│                                                         │");
        Console.ForegroundColor = ca;
        Console.ForegroundColor = a == 3 ? sea : ca;
        Console.SetCursorPosition(11, 16);



        Console.WriteLine("│                   Cuarto Problema                       │");
        Console.SetCursorPosition(11, 17);
        Console.ForegroundColor = ca;
        Console.WriteLine("│                                                         │");

        Console.SetCursorPosition(11, 18);
        Console.WriteLine("│                                                         │");
        Console.ForegroundColor = ca;

        Console.SetCursorPosition(11, 19);
        Console.ForegroundColor = a == 4 ? sea : ca;
        Console.WriteLine("│                        Salir                            │");
        Console.ForegroundColor = ca;
        Console.SetCursorPosition(11, 20);
        Console.WriteLine("│                                                         │");
        Console.SetCursorPosition(11, 21);
        Console.WriteLine("└─────────────────────────────────────────────────────────┘");
        Console.SetCursorPosition(9, 22);
        Console.WriteLine("**Usa las flechas para moverte y pulsa enter para seleccionar**");
    }
    //función que me lleva al juego en si 
    static void Opcion1()
    {
        //new Dibujo().Nombres();
    }

    //me pinta el nuevo cuadro para saber si el jugador desea volver a jugar
    static void Volvermenu(int a)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        ConsoleColor ca = ConsoleColor.DarkBlue;
        ConsoleColor sea = ConsoleColor.Red;
        Console.SetCursorPosition(11, 5);
        Console.ForegroundColor = ca;
        Console.WriteLine("┌─────────────────────────────────────────────────────────┐");
        Console.SetCursorPosition(11, 6);
        Console.WriteLine("│                                                         │");
        Console.ForegroundColor = a == 0 ? sea : ca;
        Console.SetCursorPosition(11, 7);
        Console.WriteLine("│                    Volver  a     Jugar                  │");
        Console.SetCursorPosition(11, 8);
        Console.ForegroundColor = ca;
        Console.WriteLine("│                                                         │");
        Console.SetCursorPosition(11, 9);
        Console.WriteLine("│                                                         │");
        Console.SetCursorPosition(11, 10);
        Console.ForegroundColor = a == 1 ? sea : ca;
        Console.WriteLine("│                        Salir                            │");
        Console.ForegroundColor = ca;
        Console.SetCursorPosition(11, 11);
        Console.WriteLine("│                                                         │");
        Console.SetCursorPosition(11, 12);
        Console.WriteLine("└─────────────────────────────────────────────────────────┘");
        Console.SetCursorPosition(9, 14);
        Console.WriteLine("**Usa las flechas para moverte y pulsa enter para seleccionar**");
    }

}