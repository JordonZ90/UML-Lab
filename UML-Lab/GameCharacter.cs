using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Lab
{
    abstract class GameCharacter
    {
        protected string name;
        protected int strength;
        protected int intelligence;

        public abstract string Name { get; set; }
        public abstract int Strength { get; set; }
        public abstract int Intelligence { get; set; }

        //public GameCharacter()
        //{

        //}

        //public GameCharacter(string _name, int _strength, int _intelligence)
        //{
        //    Name = _name;
        //    Strength = _strength;
        //    Intelligence = _intelligence;
        //}
        public virtual void Play()
        {
            Console.WriteLine($"{name} their strength lvl is {strength} they have an intelligence lvl of {intelligence} ");
        }
    }
}
