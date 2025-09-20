using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Management_System
{
    internal class Snake : Animal
    {
        public bool IsVenomous { get; set; }

        public Snake(string name, int age, bool isVenomous) : base(name, age)
        {
            IsVenomous = isVenomous;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Hiss!");
        }
    }
}