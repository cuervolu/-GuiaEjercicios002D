using CapaLogica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace GuiaEjercicios
{
    public class Ejercicios
    {
        public static void ejercicio1()
        {
            titulo("EJERCICIO 1");
            separador();

            mensaje("Supongamos que tenemos una lista de números enteros llamada numeros y queremos obtener todos los\r\nnúmeros que sean mayores que 5.");

            List<int> numeros = new List<int> { 2, 5, 7, 9, 10 };

            string numerosConcatenados = string.Join(", ", numeros);
            Console.WriteLine("Lista de números: {0}\n", numerosConcatenados);

            numeros = numeros.FindAll(x => x > 5);
            Console.WriteLine("Números mayores que 5: ");
            foreach (int num in numeros) Console.WriteLine(num);
        }
        public static void ejercicio2()
        {
            titulo("EJERCICIO 2");
            separador();

            mensaje("Supongamos que tenemos una lista de objetos de tipo Persona llamada personas y queremos ordenarla\r\npor edad, en orden descendente.");

            List<Persona> personas = new List<Persona>
            {
                new Persona { Nombre = "Juan", Edad = 30 },
                new Persona { Nombre = "Pedro", Edad = 25 },
                new Persona { Nombre = "María", Edad = 35 }
            };


            var orden = from x in personas
                        orderby x.Edad ascending
                        select x;

            foreach (var x in orden) Console.WriteLine("{0} de {1} años", x.Nombre, x.Edad);
        }

        public static void ejercicio3()
        {
            titulo("EJERCICIO 3");
            separador();

            mensaje("Supongamos que tenemos una lista de objetos de tipo Producto llamada productos y queremos obtener\r\nla cantidad de productos que tienen un precio mayor que 1000.");

            List<Producto> productos = new List<Producto>
            {
            new Producto { Nombre = "Laptop", Precio = 1200 },
            new Producto { Nombre = "Celular", Precio = 800 },
            new Producto { Nombre = "Televisor", Precio = 1500 }
            };

            int indice = 0;
            Console.WriteLine("{0,-5}{1,-15}{2,8}", "N°", "Nombre", "Precio");
            Console.WriteLine(new string('-', 36));

            foreach (var producto in productos)
            {
                Console.WriteLine("{0,-5}{1,-15}{2,8:C}", indice, producto.Nombre, producto.Precio);
                indice++;
            }
            Console.WriteLine(new string('-', 36));
            int count = productos.Count(p => p.Precio > 1000);
            Console.WriteLine("Cantidad de productos que tienen un precio mayor que $1000: {0}", count);
        }

        public static void ejercicio4()
        {
            titulo("EJERCICIO 4");
            separador();

            mensaje("Supongamos que tenemos una lista de números decimales llamada valores y queremos obtener la suma\r\nde todos los números en la lista.");

            List<decimal> valores = new List<decimal> { 10.5m, 20m, 15.3m, 8.7m };

            string decimalesConcatenados = string.Join(", ", valores);
            Console.WriteLine("Lista de decimales: {0}\n", decimalesConcatenados);
            Console.WriteLine(new string('-', 36));
            decimal suma = valores.Sum();

            Console.WriteLine("Suma de todos los valores: {0}", suma);
        }

        public static void ejercicio5()
        {
            titulo("EJERCICIO 5");
            separador();

            mensaje("Supongamos que tenemos dos listas de números enteros llamadas lista1 y lista2, y queremos obtener\r\nlos elementos que son distintos entre ambas listas.");

            List<int> lista1 = new List<int> { 1, 2, 3, 4 };
            List<int> lista2 = new List<int> { 2, 3, 5, 6 };
            string lista1Concatenados = string.Join(", ", lista1);
            Console.WriteLine("Lista 1: {0}\n", lista1Concatenados);
            string lista2Concatenados = string.Join(", ", lista2);
            Console.WriteLine("Lista 2: {0}\n", lista2Concatenados);

            Console.WriteLine("Elementos que son distintos entre ambas listas:");

            List<int> distintos = lista1.Except(lista2).Concat(lista2.Except(lista1)).ToList();
            foreach (int num in distintos) Console.WriteLine(num);
        }

        public static void ejercicio6()
        {
            titulo("EJERCICIO 6");
            separador();

            mensaje("Supongamos que tenemos una lista de cadenas llamada nombres y queremos obtener los nombres que\r\ncontienen la subcadena \"ana\".");

            List<string> nombres = new List<string> { "Ana", "María", "Luciana", "Juan",
            "Anabel" };

            string nombresConcatenados = string.Join(", ", nombres);
            Console.WriteLine("Lista de nombres: {0}\n", nombresConcatenados);
            Console.WriteLine(new string('-', 36));

            Console.WriteLine("Nombres que contienen \"Ana\":");

            var nombresConAna = nombres.Where(nombre => nombre.ToLower().Contains("ana")).ToList();

            foreach (string nombre in nombresConAna) Console.WriteLine(nombre);
        }

        public static void ejercicio7()
        {
            titulo("Ejercicio 7");
            separador();

            mensaje("Supongamos que tenemos una lista de objetos de tipo Producto llamada productos y queremos obtener\r\nlos productos que tienen un precio mayor que 1000 y una cantidad en stock mayor que 10.");

            List<Producto> productos = new List<Producto>
            {
                new Producto { Nombre = "Laptop", Precio = 1200, Stock = 15 },
                new Producto { Nombre = "Celular", Precio = 800, Stock = 5 },
                new Producto { Nombre = "Televisor", Precio = 1500, Stock = 20 }
            };

            productos = productos.FindAll(x => x.Precio > 1000 && x.Stock > 10);

            int indice = 1;
            /* 
             * He ajustado la anchura de cada columna usando el especificador de formato { n, m}, donde n es el índice de la columna y m es la anchura de la columna en caracteres. También he usado la alineación adecuada para cada columna: la columna "N°" está alineada a la izquierda, la columna "Nombre" está alineada a la izquierda, la columna "Stock" está alineada a la izquierda, y la columna "Precio" está alineada a la derecha y muestra el símbolo de dólar.
             */

            Console.WriteLine("{0,-5}{1,-15}{2,-8}{3,8}", "N°", "Nombre", "Stock", "Precio");
            Console.WriteLine(new string('-', 36));

            foreach (var producto in productos)
            {
                Console.WriteLine("{0,-5}{1,-15}{2,-8}{3,8:C}", indice, producto.Nombre, producto.Stock, producto.Precio);
                indice++;
            }
        }

        public static void ejercicio8()
        {
            titulo("Ejercicio 8");
            separador();

            mensaje("Supongamos que tenemos dos listas de números enteros llamadas lista1 y lista2, y queremos obtener\r\nlos elementos que se encuentran en ambas listas.");

            List<int> lista1 = new List<int> { 1, 2, 3, 4 };
            List<int> lista2 = new List<int> { 2, 3, 5, 6 };

            string lista1Concatenados = string.Join(", ", lista1);
            Console.WriteLine("Lista 1: {0}", lista1Concatenados);
            string lista2Concatenados = string.Join(", ", lista2);
            Console.WriteLine("Lista 2: {0}", lista2Concatenados);

            Console.WriteLine("Elementos que se encuentran en ambas listas:");

            var resultado = lista1.Intersect(lista2);
            foreach (var item in resultado) { Console.WriteLine(item); }
        }

        private static void titulo(string titulo)
        {
            int windowWidth = Console.WindowWidth;

            Console.WriteLine(new string('*', windowWidth));
            Console.WriteLine("*" + new string(' ', (windowWidth - titulo.ToUpper().Length - 2) / 2) + titulo.ToUpper() + new string(' ', (windowWidth - titulo.ToUpper().Length - 2) / 2) + "*");
            Console.WriteLine("*" + new string(' ', windowWidth - 2) + "*");
            Console.WriteLine(new string('*', windowWidth));
        }

        /*
         * Usando un carácter de repetición (\u2500) para crear una línea horizontal. Se usa en combinación con la función Console.WindowWidth para crear una línea de separación que abarque todo el ancho de la consola. 
         */
        private static void separador()
        {
            string separator = new string('\u2500', Console.WindowWidth); Console.WriteLine(separator);
        }
        private static void mensaje(string mensaje)
        {
            for (int i = 0; i < mensaje.Length; i++)
            {
                Console.Write(mensaje[i]);
                Thread.Sleep(10);
            }

            Console.ReadKey();
            Console.WriteLine("\n");
        }
    }
}
