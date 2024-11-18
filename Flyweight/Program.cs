using Flyweight;
using System;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {
        CharacterFactory factory = new CharacterFactory();

        Character char1 = factory.CreateCharacter("John", "Warrior", "warrior.png");
        char1.DisplayCharacterInfo();

        Character char2 = factory.CreateCharacter("John", "Mage", "mage.png");
        char2.DisplayCharacterInfo();

        Character char3 = factory.CreateCharacter("John", "Warrior", "warrior.png");
        char3.DisplayCharacterInfo();

        char3.Level = 5;
        char3.Experience = 100;
        char3.DisplayCharacterInfo();
    }
}
