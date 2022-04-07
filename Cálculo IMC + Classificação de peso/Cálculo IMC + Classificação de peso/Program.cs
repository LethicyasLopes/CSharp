using System;

namespace Cálculo_IMC___Classificação_de_peso
{
    internal class Program
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

            {
                if (IMC < 18.5)
                {
                    Console.WriteLine("Você está abaixo do peso. Procure se alimentar melhor!");
                }
                else if (IMC < 25)
                {
                    Console.WriteLine("Você está com o peso normal. Parabéns, continue assim!");
                }
                else if (IMC < 30)
                {
                    Console.WriteLine("Você está com sobrepeso. Fique atento!");
                }
                else
                {
                    Console.WriteLine("Você está com obesidade. Procure um médico, tenha uma alimentação balanceada e faça mais exercícios físicos!");
                }

            }
        }
    }
}
