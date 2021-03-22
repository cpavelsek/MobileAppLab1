﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
