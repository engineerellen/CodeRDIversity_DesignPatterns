using DesignPatterns.AbstractFactory;
using System;

namespace DesignPatterns.Façade
{
    internal class BrincarComAnimal
    {
        public void Brincar(IAnimal animal)
        {
            Console.WriteLine("Brincando com o animal...");
            animal.EmitirSom();
        }
    }
}
