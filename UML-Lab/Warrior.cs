using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Lab
{
    class Warrior : GameCharacter
    {
        private string weaponType;


        public override string Name { get => name; set => name = value; }
        public override int Strength { get => strength; set => strength = value; }
        public override int Intelligence { get => intelligence; set => intelligence = value; }
        public string Weapontype { get => weaponType; set => weaponType = value; }

        public Warrior(string _name, int _strength, int _intelligence, string _weaponType)
        {
            name = _name;
            strength = _strength;
            intelligence = _intelligence;
            weaponType = _weaponType;
        }

        public override void Play()
        {
            //
            Console.WriteLine($"{name} their strength lvl is {strength} they have an intelligence lvl of {intelligence}. Their weapon of choice is {weaponType} ");
        }
    }
}
