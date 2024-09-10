using DesignPatterns.AbstractFactory;

namespace DesignPatterns.FactoryMethod
{
    internal abstract class AnimalFactoryMethod
    {
        // Método abstrato que as subclasses devem implementar para criar um animal
        public abstract IAnimal CriarAnimal();

        public virtual string Comer() =>
            "grrr!";

        public virtual string Andar()
        {
            return "Está andando!";
        }

    }
}