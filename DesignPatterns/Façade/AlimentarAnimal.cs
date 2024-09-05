using DesignPatterns.AbstractFactory;
using System;

namespace DesignPatterns.Façade
{
    internal class AlimentarAnimal
    {
        public void Alimentar(IAnimal animal)
        {
            Console.WriteLine("Alimentando o animal...");
            animal.EmitirSom();
        }
    }
}