using Characters.Warriors;
using Characters.Spellcasters;
using System;
using Enumerations;
using Characters;
using System.Collections.Generic;
using Interfaces;

public class EntryPoint
{
    static void Main()
    {


        Warrior firstWarrior = new Warrior(78, 180, "Amy", Faction.GoodGuy);
        Mage firstMage = new Mage();
        Console.WriteLine(firstWarrior.AddNumber(7,5));

        Console.WriteLine(firstWarrior.HealthPoints);
        Console.WriteLine(firstMage.Mana);
        firstMage.CastSpell(firstWarrior);

        Character secondWarrior = new Warrior();
 
        List<Character> theCharacters = new List<Character>();

        List<ICalculator> calculators = new List<ICalculator>();
        calculators.Add(firstWarrior);
        calculators.Add(firstMage);



        theCharacters.Add(firstWarrior);
        theCharacters.Add(firstMage);



        foreach (var character in theCharacters)
        {
            if(character is Warrior)
            {
                Warrior tempWarrior = character as Warrior;
                Console.WriteLine(tempWarrior.SwordWeapon.Damage);
            }
        }


        Console.WriteLine("After spell cast:" + firstWarrior.HealthPoints);
        Console.WriteLine("After spell cast:" + firstMage.Mana);

        PerformGreeting(theCharacters);
        Character[] theCharactersAgain = new Character[2];
        theCharactersAgain[0] = firstMage;
        theCharactersAgain[1] = firstWarrior;

        PerformGreeting(theCharactersAgain);
    
    }

    public static void PerformGreeting(IEnumerable<Character> characters)
    {
        foreach (var item in characters)
        {
            item.Greetings("Sue");
        }


    }



}
