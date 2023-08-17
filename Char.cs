using System.Net;

namespace Program
{
    class Character {
        public string CharacterClass;
        public string CharacterName;

        public Character(string CharacterClass, string CharacterName) {
            this.CharacterClass= CharacterClass;
            this.CharacterName=CharacterName;
        }

        internal void print()
        {
            throw new NotImplementedException();
        }
    }
}