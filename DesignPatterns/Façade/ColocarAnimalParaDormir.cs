using DesignPatterns.AbstractFactory;
using System;

namespace DesignPatterns.Façade
{
    internal class ColocarAnimalParaDormir
    {
        public void Dormir(IAnimal animal)
        {
            Console.WriteLine("Colocando o animal para dormir...");
            animal.EmitirSom();
        }
    }
}