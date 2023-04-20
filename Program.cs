using System;
using System.Text.RegularExpressions;

namespace GuiaEjercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();

        }

        private static void menu()
        {
            bool continuar = true;
            string[] opcionesMenu = {
              "Obtener todos los elementos de una lista que cumplan con una condición específica",
              "Ordenar una lista en orden ascendente o descendente",
              "Obtener la cantidad de elementos de una lista que cumplan con una condición específica",
              "Obtener la suma de los valores de una lista",
              "Obtener los elementos distintos de dos listas",
              "Obtener los elementos de una lista que contienen una subcadena específica",
              "Obtener los elementos de una lista que cumplen con varias condiciones",
              "Obtener los elementos de una lista que se encuentran en otra lista",
              "Salir"
            };
            while (continuar)
            {
                Console.WriteLine(@"

 _____  _   _  _____  ___   ______  _____   _____   ___  _____ ______  _____  _____  _____  _____  _____  _____   
|  __ \| | | ||_   _|/ _ \  |  _  \|  ___| |  ___| |_  ||  ___|| ___ \/  __ \|_   _|/  __ \|_   _||  _  |/  ___|  
| |  \/| | | |  | | / /_\ \ | | | || |__   | |__     | || |__  | |_/ /| /  \/  | |  | /  \/  | |  | | | |\ `--.   
| | __ | | | |  | | |  _  | | | | ||  __|  |  __|    | ||  __| |    / | |      | |  | |      | |  | | | | `--. \  
| |_\ \| |_| | _| |_| | | | | |/ / | |___  | |___/\__/ /| |___ | |\ \ | \__/\ _| |_ | \__/\ _| |_ \ \_/ //\__/ /  
 \____/ \___/  \___/\_| |_/ |___/  \____/  \____/\____/ \____/ \_| \_| \____/ \___/  \____/ \___/  \___/ \____/   
                                                                                                                  
                                                                                                                 

                  ");

                string separator = new string('\u2500', Console.WindowWidth); Console.WriteLine(separator);

                Console.WriteLine();
                Console.WriteLine("Opciones:");

                for (int i = 0; i < opcionesMenu.Length; i++)
                {
                    string opcion = opcionesMenu[i];
                    string opcionSinColor = Regex.Replace(opcion, "\u001b\\[\\d+m", ""); // quita los códigos de escape ANSI
                    Console.WriteLine($"{i + 1}. {opcionSinColor}");
                }


                Console.Write("\nOpción seleccionada: ");
                string opcionSeleccionada = Console.ReadLine();

                Console.WriteLine();
                switch (opcionSeleccionada)
                {
                    case "1":
                        EjecutarOpcion(Ejercicios.ejercicio1);
                        break;
                    case "2":
                        EjecutarOpcion(Ejercicios.ejercicio2);
                        break;
                    case "3":
                        EjecutarOpcion(Ejercicios.ejercicio3);
                        break;
                    case "4":
                        EjecutarOpcion(Ejercicios.ejercicio4);
                        break;
                    case "5":
                        EjecutarOpcion(Ejercicios.ejercicio5);
                        break;
                    case "6":
                        EjecutarOpcion(Ejercicios.ejercicio6);
                        break;
                    case "7":
                        EjecutarOpcion(Ejercicios.ejercicio7);
                        break;
                    case "8":
                        EjecutarOpcion(Ejercicios.ejercicio8);
                        break;
                    case "9":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
                Console.Clear();
            }
        }
        private static void EjecutarOpcion(Action opcionSeleccionada)
        {
            Console.Clear();
            opcionSeleccionada();
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
