namespace DesignPatterns.AbstractFactory
{
    internal class CachorroAbstractFactory : IAnimalAbstractFactory
    {
        public IAnimal CriarAnimal() =>
                    new Cachorro();

    }
}