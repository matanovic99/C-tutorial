
using System.Xml.Serialization;

namespace Program
{
    class Character
    {

        public string CharacterClass;
        public string CharacterName;
        public int strenght = 10;
        public int magic = 0;
        public int BloodThirst = 0;
        public int food = 2;
        public int water = 2;


        public Character (string CharacterClass, string CharacterName)
        {
            this.CharacterClass = CharacterClass;
            this.CharacterName = CharacterName;


        }
        public void print () {
            Console.WriteLine("Character class: " + CharacterClass + "\nCharacter name: " + CharacterName);
        }
    }
}