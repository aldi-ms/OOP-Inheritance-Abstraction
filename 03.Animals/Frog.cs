﻿using System;

namespace _03.Animals
{
    public class Frog : Animal
    {
        public Frog(string name, int age, Gender gender)
            : base(name, age, gender)
        { }

        public override void ProduceSound()
        {
            Console.WriteLine("Kvak-kvak!");
        }
    }
}
