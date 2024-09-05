using System;

namespace DesignPatterns.AbstractFactory
{
    internal class Gato : IAnimal
    {
        public void EmitirSom() =>
            Console.WriteLine(" Miau!");
    }
}