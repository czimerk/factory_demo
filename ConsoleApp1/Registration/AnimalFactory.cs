using AFact.Abstractions;
using AFact.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AFact.Registration
{
    class AnimalFactory
    {
        public Animal Create(Species species, string name, DateTime birthDate, string ownerName)
        {
            Animal a = null;

            switch (species)
            {
                case Species.Cat:
                    {
                        a = new Cat(name, birthDate, ownerName);
                        break;
                    }
                case Species.Dog:
                    {
                        a = new Dog(name, birthDate, ownerName);
                        break;
                    }
                case Species.ManBearPig:
                    {
                        a = new ManBearPig(name, birthDate, ownerName);
                        break;
                    }
            }

            return a;
        }
    }
}
