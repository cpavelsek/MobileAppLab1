using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface ITalkable
    {
        

        public string Talk()
        {
            return "Talking";
        }

        public string GetName()
        {
            return "Name";
        }

    }
}
