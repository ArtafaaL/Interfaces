using System;
using Animals;
using Covariation;
using Contrvariation;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ковариация. Из зоопарка сбежал хищник
            Console.WriteLine("Из зоопарка сбежал хищник");

            Covariation.IZoo<Animal> animal = new Covariation.Zoo<Predator>(new Predator()); //Создаем животное, в котором хранится хищник
            Console.WriteLine($" Является ли любой хищник живтоным - {animal is Covariation.IZoo<Animal>}") ; 
            Console.WriteLine($" Является ли любой хищник хищником - {animal is Covariation.IZoo<Predator>}"); 
            Console.WriteLine($" Является ли любой хищник енотом - {animal is Covariation.IZoo<Racoon>}");

            Console.WriteLine();

            //Контрвариация. В зоопарк труебутся хищник
            Console.WriteLine("В зоопарк труебутся хищник");

            Contrvariation.IZoo<Predator> newAnimal = new Contrvariation.Zoo<Predator>(new Predator()); 
            Console.WriteLine($" Любое ли животное хищник - {newAnimal is Contrvariation.IZoo<Animal>}"); 
            Console.WriteLine($" Любой ли хищник хищник - {newAnimal is Contrvariation.IZoo<Predator>}"); 
            Console.WriteLine($" Любой ли енот хищник - {newAnimal is Contrvariation.IZoo<Racoon>}");
        }
    }
}
