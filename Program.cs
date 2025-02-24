using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaElNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado, contador = 0;
            Random numeroAle = new Random();
            int aleatorio = numeroAle.Next(1, 51);

            do
            {
                Console.Write("Ingrese el numero a adivinar: ");
                numeroIngresado = int.Parse(Console.ReadLine());
                contador++;

                if (numeroIngresado == aleatorio)
                {
                    Console.WriteLine($"Felicidades, Adivinaste el numero y lo lograste en {contador} intentos");
                    break;
                }
                else
                {
                    if (numeroIngresado > aleatorio)
                    {
                        Console.WriteLine("El numero es menor");
                    }
                    if (numeroIngresado < aleatorio)
                    {
                        Console.WriteLine("El numero es mayor");
                    }
                }
            }
            while (true);
            


           

        }
    }
}
