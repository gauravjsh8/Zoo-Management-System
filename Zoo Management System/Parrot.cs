using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Management_System
{
    internal class Parrot : Animal
    {
        public string Vocabulary { get; set; }

        public Parrot(string name, int age, string vocabulary) : base(name, age)
        {
            Vocabulary = vocabulary;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: {Vocabulary}");
        }
    }
}