using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._0
{
    class Program
    {
        static void Faren()
        {
            Double cel, far, kel;
            //Aparece en pantalla
            Console.WriteLine("\n...>Escribe los grados celcius: ");

            //Se leen los grados Celcius y se covierten a double
            cel = Convert.ToDouble(Console.ReadLine());
            //Se obtienen los grados Farenheit
            far = cel * 9.0 / 5.0 + 32;
            kel = cel + 273;

            //Se muestran los grados Farenheit resultantes
            Console.WriteLine("\n---{0} grados Celcius son {1} grados Farenheit", cel, far, kel);
        }

        static void Pies()
        {
            double metros, pies;

            Console.WriteLine("\n--->Ingrese cantidad de metros: ");
            metros = double.Parse(Console.ReadLine());

            pies = metros * 3.28;
            Console.WriteLine("\n---{0} metros son {1} Pies",metros, pies);
  
        }

        static void Libras()
        {
            double kilo, libra;

            Console.WriteLine("\n--->Ingrese cantidad de kilos: ");
            kilo = double.Parse(Console.ReadLine());
            
            libra = kilo * 2.20 ;
            Console.WriteLine("\n---{0} Kilogramos son {1} Libras",kilo,libra);
        }
        static void Main(string[] args)
        {
            Console.WindowHeight = 30;  // alto de la ventana           
            Console.WindowWidth = 75; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            string opc;

            Console.WriteLine("\t\tPROGRAMA PARA CONVERSIONES\n");
            Console.WriteLine("\t\tElige el tipo de conversion");
            Console.WriteLine("\t\n\n--->Presiona T si quieres convertir Celcius a Farenheit");
            Console.WriteLine("\t\n--->Presiona L si quieres convertir Metros a Pies");
            Console.WriteLine("\t\n--->Presiona P si quieres convertir Kilogramos a Libras\n");
            Console.WriteLine("\t\tElige T, L , P : \n");

            //Recoger lo que puso el usuario
            opc = Console.ReadLine();

            switch (opc)
            {
                case "F":
                case "f":
                    Console.WriteLine("--->Conversion a F");
                    //invocaion del metodo
                    Faren();
                    break;

                case "L":
                case "l":
                    Console.WriteLine("--->Conversion a L");
                    Pies();
                    break;

                case "P":
                case "p":
                    Console.WriteLine("--->Conversion a P");
                    Libras();
                    break;
               

                default:
                    Console.WriteLine("\n Tipo de conversion no valida");
                    break;

            }

            //Esperando a que el usuario toque una tecla
            Console.ReadKey();
        }
    }
}

