using System;

namespace UML_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard gandalf = new Wizard("Gandalf the Gray", 300, 400, 655, 60);
            Wizard sauron = new Wizard("Sauron", 1000, 250, 800, 100);
            Wizard saruman = new Wizard("Saruman", 315, 300, 675, 60);
            Warrior aragorn = new Warrior("Aragorn", 200, 255, "Sword");
            Warrior gimli = new Warrior("Gimli", 225, 250, "Axe");
            Warrior legolas = new Warrior("Legolas", 230, 250, "Bow");// Legolas 


            GameCharacter[] gameCharacters = { gandalf, sauron, saruman, aragorn, gimli, legolas };

            foreach (var z in gameCharacters)
            {
                z.Play();
            }
        }
    }
}
