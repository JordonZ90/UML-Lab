using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Lab
{
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;
        public override string Name { get => name; set => name = value; }
        public override int Strength { get => strength; set => strength = value; }
        public override int Intelligence { get => intelligence; set => intelligence = value; }
        public int SpellNumber { get => spellNumber; set => intelligence = value; }
        public override int MagicalEnergy { get => magicalEnergy; set => magicalEnergy = value; }

        public Wizard(string _name, int _strength, int _intelligence, int _spellNumber, int _magicalEnergy)
        {
            name = _name;
            strength = _strength;
            intelligence = _intelligence;
            spellNumber = _spellNumber;
            MagicalEnergy = _magicalEnergy;
        }

        public override void Play()
        {
            Console.WriteLine($"{name} their strength lvl is {strength} they have an intelligence lvl of {intelligence}. Spells:{spellNumber} Magical Energy lvl: {MagicalEnergy} ");


        }

    }
}
