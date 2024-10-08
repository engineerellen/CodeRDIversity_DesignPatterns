﻿using DesignPatterns.AbstractFactory;
using DesignPatterns.Façade;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Singleton;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChamarSingleton();

            ChamarAbstractFactory();

            ChamarFactoryMethod();

            ChamarFacade();

        }

        private static void ChamarFacade()
        {
            // Criando instâncias de animais
            IAnimal cachorro = new Cachorro();
            IAnimal gato = new Gato();

            // Criando a Façade
            BabaDePet_Facade babaDePet = new BabaDePet_Facade();

            // Usando a Façade para simplificar a interação
            Console.WriteLine("Cuidados com o cachorro:");
            babaDePet.CuidadosComAnimal(cachorro);

            Console.WriteLine("\nCuidados com o gato:");
            babaDePet.CuidadosComAnimal(gato);
        }

        private static void ChamarFactoryMethod()
        {
            // Criando uma fábrica de cachorros
            AnimalFactoryMethod cachorroFactory = new CachorroFactoryMethod();
            IAnimal cachorro = cachorroFactory.CriarAnimal();
            cachorro.EmitirSom();
            Console.WriteLine(cachorroFactory.Andar());

            // Criando uma fábrica de gatos
            AnimalFactoryMethod gatoFactory = new GatoFactoryMethod();
            IAnimal gato = gatoFactory.CriarAnimal();
            gato.EmitirSom();
            Console.WriteLine(gatoFactory.Andar());
        }

        private static void ChamarAbstractFactory()
        {
            // Criando uma fábrica de cachorros
            IAnimalAbstractFactory cachorroFactory = new CachorroAbstractFactory();
            IAnimal cachorro = cachorroFactory.CriarAnimal();
            cachorro.EmitirSom();

            // Criando uma fábrica de gatos
            IAnimalAbstractFactory gatoFactory = new GatoAbstractFactory();
            IAnimal gato = gatoFactory.CriarAnimal();
            gato.EmitirSom();
        }

        private static void ChamarSingleton()
        {
            AnimalSingleton animal = AnimalSingleton.InstanciaAnimalSingleton;

            AnimalSingleton animal1 = AnimalSingleton.InstanciaAnimalSingleton;


            // Chamando um método da instância
            animal.EmitirSom();

            animal1.EmitirSom();
        }
    }
}
