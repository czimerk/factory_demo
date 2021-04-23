using AFact.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AFact.Implementation
{
    internal class Dog : Animal
    {
        public Dog(string name, DateTime birthDate, string ownerName) : base(Species.Dog, name, birthDate, ownerName)
        {

        }

        private string Wuff() 
        {
            return "Wuff";
        }

        public override string Speak()
        {
            return Wuff();
        }

    }
}
