using DesignPatterns.AbstractFactory;

namespace DesignPatterns.FactoryMethod
{
    internal class CachorroFactoryMethod : AnimalFactoryMethod
    {
        public override IAnimal CriarAnimal() =>
                new Cachorro();

        public override string Andar()
        {
            return "Doguinho anda!";
        }
    }
}