using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Management_System
{
    public abstract class Animal
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        protected Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void MakeSound();
    }
}