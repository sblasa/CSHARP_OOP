using Characters.Warriors;
using System; 

public class EntryPoint
{
    static void Main()
    {

        Warrior firstWarrior = new Warrior();
        Warrior secondWarrior = new Warrior(71, 120);
        Warrior thirdWarrior = new Warrior(68, 110, "Arnold");

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
