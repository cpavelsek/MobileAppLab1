using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cat : Pet, ITalkable
    {
        private int mousesKilled;

        public Cat(int mousesKilled, String name) : base(name)
        {
            this.name =name;
            this.mousesKilled = mousesKilled;
        }

        public int getMousesKilled()
        {
            return mousesKilled;
        }

        public void addMouse()
        {
            mousesKilled++;
        }

        
        public string Talk()
        {
            return "Meow";
        }

        
        public string ToString()
        {
            return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;
        }
    }
}
