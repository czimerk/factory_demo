using AFact.Abstractions;
using System;

namespace AFact.Implementation
{
    internal class ManBearPig : Animal
    {
        private string ownerName;

        public ManBearPig(string name, DateTime birthDate, string ownerName) : base(Species.ManBearPig, name, birthDate, ownerName)
        {
        }

        private string RoarOink()
        {
            return "Roar Oink";
        }

        public override string Speak()
        {
            return RoarOink();
        }
    }
}