using AFact.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AFact.Implementation
{
    internal class Cat : Animal
    {
        public Cat(string name, DateTime birthDate, string ownerName) : base(Species.Cat, name, birthDate, ownerName)
        {
        }

        private string Meow()
        {
            return "Meow";
        }

        public override string Speak()
        {
            return Meow();
        }
    }
}
