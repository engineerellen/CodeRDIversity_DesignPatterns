using System;

namespace DesignPatterns.AbstractFactory
{
    internal class Cachorro : IAnimal
    {
        public void EmitirSom() =>
            Console.WriteLine("Au Au!");
    }
}