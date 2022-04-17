using System;
using System.Collections.Generic;
using Zoologico.src;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoológico");

            List<Animal> animais = new List<Animal>(
                new Animal[]{
                    new Gato("Gato Bartholomeu", "Cinza", "Felino"),
                    new Cachorro("Cachorro Sushi", "Preto", "Canídio"),
                    new Cachorro("Cachorro Nino", "Branco", "Canídio"),
                    new Gato("Gato Alfred", "Marrom", "Felino"),
                    new Macaco("Macaco King", "Marrom", "Primata"),
                }
            );

            foreach (Animal animal in animais)
            {
                if (animal.Classificacao == "Canídio")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Au au!");
                } 
                else if (animal.Classificacao == "Felino")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Miau!");
                }
                else if (animal.Classificacao == "Primata")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Huhu HAHA!");
                }
            }

        }
    }
}
