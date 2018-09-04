using Characters.Warriors;
using Characters.Spellcasters;
using System;
using Enumerations;

public class EntryPoint
{
    static void Main()
    {

        Warrior firstWarrior = new Warrior();
        //firstWarrior.Move(500);
        Warrior secondWarrior = new Warrior(71, 120);
        Warrior thirdWarrior = new Warrior(68, 110);
        Warrior fourthWarrior = new Warrior(78, 180, "Amy", Faction.GoodGuy);
        Mage firstMage = new Mage();
        firstWarrior.AddNumber(3, 7);
        firstMage.AddNumber(3, 7);
        //firstMage.Move(200);
        //try
        //{
        //    firstMage.Age = 25;
        //}

        //catch (ArgumentOutOfRangeException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        
        
        //Console.WriteLine(fourthWarrior.HealthPoints);
    

        Tools.ColorfulwriteLine(firstWarrior.ID.ToString(), ConsoleColor.DarkRed);
        Tools.ColorfulwriteLine(secondWarrior.ID.ToString(), ConsoleColor.DarkYellow);
        Tools.ColorfulwriteLine(thirdWarrior.ID.ToString(), ConsoleColor.Cyan);

        Warrior.GetDefaultValues(secondWarrior);
        thirdWarrior.SpecialWarriorGreeting();
        //Warrior theGoodGal = new Warrior(62, 120, "Sue");
        //Warrior theBadGal = new Warrior(63, 136, "Alice");
        ////you can set those values below if your constructor doesn't have any parameters that you need to pass in
        ////it can be set below
        //// theBadGal.Height = 63;
        ////theBadGal.Weight = 136;
        ////theBadGal.Name = "Alice";

        //Warrior youngWarrior = new Warrior(150, 50);
        //// youngWarrior.Age = 18;
        //Console.WriteLine($"Warrior's age is {youngWarrior.Age}.");

        //Console.WriteLine("Here's the height " + theGoodGal.Height);
        //Console.WriteLine("Here's the weight " + theGoodGal.Weight);
        //try
        //{
        //    theGoodGal.Age = 28;
        //    theBadGal.Age = 15;

        //}
        //catch (ArgumentOutOfRangeException ex)
        //{

        //    Console.WriteLine(ex.Message);
        //}


        //System.Console.WriteLine(theGoodGal.Age);
        //System.Console.WriteLine(theBadGal.Age);


        //theBadGal.Greetings(theGoodGal);
        //System.Console.WriteLine(theGoodGal.SwordWeapon.Damage);
    }
}
