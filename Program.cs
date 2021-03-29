using System;

namespace A133590.Ejercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 31.");
            Console.WriteLine("Programa que presenta la diferencia entre dos fechas");
            Console.Write("Por favor, ingrese una fecha: ");
            DateTime fecha;
            if (!DateTime.TryParse(Console.ReadLine(), out fecha))
            {
                Console.WriteLine("La fecha ingresada no es válida.");
                return;
            }

            Console.Write("Por favor, ingrese otra fecha: ");
            DateTime otraFecha;
            if (!DateTime.TryParse(Console.ReadLine(), out otraFecha))
            {
                Console.WriteLine("La fecha ingresada no es válida.");
                return;
            }

            TimeSpan diferencia = fecha - otraFecha;
            int dias = Math.Abs((int)diferencia.TotalDays);
            DateTime auxiliar = DateTime.MinValue;
            auxiliar = auxiliar.AddDays(dias);


            Console.WriteLine("Diferencia:");
            Console.WriteLine($"Años: {auxiliar.Year - 1}");
            Console.WriteLine($"Meses: {auxiliar.Month - 1}");
            Console.WriteLine($"Días: {auxiliar.Day - 1}");



            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
