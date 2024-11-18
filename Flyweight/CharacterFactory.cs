using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class CharacterFactory
    {
        private readonly Dictionary<string, Character> _characters = new();

        public Character CreateCharacter(string name, string type, string image)
        {
            string key = $"{name}_{type}";

            if (_characters.ContainsKey(key))
            {
                return _characters[key];
            }
            var newCharacter = new Character(name, type, image);
            _characters[key] = newCharacter;
            return newCharacter;
        }
    }
}
