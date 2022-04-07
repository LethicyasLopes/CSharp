using System;

namespace IMC
{
    internal class IMClesson
    {
        static void Main(string[] args)
        {
            float altura;
            float peso;
            float IMC;

            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Olá " + nome + ". Qual é a sua altura?: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Maravilha. Para finalizar, informe seu peso: ");
            peso = float.Parse(Console.ReadLine());

            IMC = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + IMC);

        
        }
    }
}


