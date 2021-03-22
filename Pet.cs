using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Pet
    {
        protected string name;

        public Pet(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
