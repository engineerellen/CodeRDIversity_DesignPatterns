using DesignPatterns.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    internal class CachorroFactoryMethod : AnimalFactoryMethod
    {
        public override IAnimal CriarAnimal()=>
                new Cachorro();

    }
}