using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Dog : Pet, ITalkable
    {
        private bool friendly;

        public Dog(bool friendly, string name) : base(name)
        {
            this.name = name;
            this.friendly = friendly;
        }

        

        public bool isFriendly()
        {
            return friendly;
        }

        
        public string Talk()
        {
            return "Bark";
        }

        
        override public string ToString()
        {
            return "Dog: " + "name=" + name + " friendly=" + friendly;
        }
    }
}
