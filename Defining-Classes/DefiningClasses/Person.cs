﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DefiningClasses
{
   public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age)
            : this()
        {
            Age = age;
        }

        public Person(string name , int age)
        : this(age)
        {
            Name = name;
        }
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int Age { get => this.age; set => this.age = value; }
    }
}
