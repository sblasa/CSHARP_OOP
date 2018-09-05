using Characters.Warriors;
using Characters.Spellcasters;
using System;
using Enumerations;

public class EntryPoint
{
    static void Main()
    {


        Warrior firstWarrior = new Warrior(78, 180, "Amy", Faction.GoodGuy);
        Mage firstMage = new Mage();

        Console.WriteLine(firstWarrior.HealthPoints);
        Console.WriteLine(firstMage.Mana);
        firstMage.CastSpell(firstWarrior);


        Console.WriteLine("After spell cast:" + firstWarrior.HealthPoints);
        Console.WriteLine("After spell cast:" + firstMage.Mana);

        //firstMage.Move(200);
        //try
        //{
        //    firstMage.Age = 25;
        //}

        //catch (ArgumentOutOfRangeException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}






        //try
        //{
        //    theGoodGal.Age = 28;
        //    theBadGal.Age = 15;

        //}
        //catch (ArgumentOutOfRangeException ex)
        //{

        //    Console.WriteLine(ex.Message);
        //}

    }
}
