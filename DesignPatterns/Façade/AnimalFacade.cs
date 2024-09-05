using DesignPatterns.AbstractFactory;

namespace DesignPatterns.Façade
{
    internal class AnimalFacade
    {
        private readonly AlimentarAnimal _alimentarAnimal;
        private readonly BrincarComAnimal _brincarComAnimal;
        private readonly ColocarAnimalParaDormir _colocarParaDormir;

        public AnimalFacade()
        {
            _alimentarAnimal = new AlimentarAnimal();
            _brincarComAnimal = new BrincarComAnimal();
            _colocarParaDormir = new ColocarAnimalParaDormir();
        }

        public void CuidadosComAnimal(IAnimal animal)
        {
            // Interface simplificada para realizar várias ações
            _alimentarAnimal.Alimentar(animal);
            _brincarComAnimal.Brincar(animal);
            _colocarParaDormir.Dormir(animal);
        }
    }
}