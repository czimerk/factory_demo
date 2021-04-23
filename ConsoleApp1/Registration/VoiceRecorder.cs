using AFact.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AFact.Registration
{
    class VoiceRecorder
    {
        public void Record(IAnimal animal)
        {
            Console.WriteLine(animal.Speak());
        }
    }
}
