using System;

namespace TabuadaCSharp
{
    internal class Tabuada
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABUADA");
            Console.WriteLine("insira o número da tabuada que queira aprender: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= 10; x++)
            {
                int resultado = (numero * x);
                Console.WriteLine($"{numero} * {x}  = {resultado}");
            }
        }
    }
}