namespace DesignPatterns.AbstractFactory
{
    internal class GatoAbstractFactory : IAnimalAbstractFactory
    {
        public IAnimal CriarAnimal() =>
            new Gato();
    }
}