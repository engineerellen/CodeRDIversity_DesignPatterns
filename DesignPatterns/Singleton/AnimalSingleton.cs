using System;

namespace DesignPatterns.Singleton
{
    internal class AnimalSingleton
    {

        // Instância única da classe (Singleton)
        private static AnimalSingleton _instanciaAnimalSingleton;

        // Objeto de bloqueio para garantir segurança em ambientes multithread
        private static readonly object _lock = new object();

        // Propriedade pública para acessar a instância única
        public static AnimalSingleton InstanciaAnimalSingleton
        {
            get
            {
                // Usamos o bloqueio para garantir que somente uma instância seja criada, mesmo em cenários com múltiplas threads
                lock (_lock)
                {
                    if (_instanciaAnimalSingleton == null)
                        _instanciaAnimalSingleton = new AnimalSingleton();

                    return _instanciaAnimalSingleton;
                }
            }
        }

        // Construtor privado para evitar a criação de instâncias fora da classe
        private AnimalSingleton()
        {
        }

        // Exemplo de método que pode existir na classe Animal
        public void EmitirSom() =>
            Console.WriteLine("O animal emite um som.");

    }
}