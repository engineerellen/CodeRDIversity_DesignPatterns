using DesignPatterns.AbstractFactory;

namespace DesignPatterns.FactoryMethod
{
    internal class GatoFactoryMethod : AnimalFactoryMethod
    {
        public override IAnimal CriarAnimal() =>
            new Gato();

        public override string Andar() =>
            "Gato Anda";

        public string Ronronar() =>
            "Prrr!";
    }
}
