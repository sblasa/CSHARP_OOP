using System;
using Weapons;

namespace Characters.Warriors
{
    public class Warrior
    {
        private int height;
        private int weight;
        private string name;
        private int age;
        private Sword swordWeapon;

        public int Height
        {
            get
            {
                return height;

            }
            set
            {
                height = value;

            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }
        public string Name
        {
            get
            {
                return name; 
            }
            set
            {
                name = value;
            }

        }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if(value >= 18 && value <= 45)
                {
                    age = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The selected age for {name}, is not a proper age for a Warrior. Please enter an age from 18 to 45.");
                    
                }
                

            }

        }
        public Sword SwordWeapon
        {
            get
            {
                return this.swordWeapon;
            }
            set
            {
                swordWeapon = value;
            }

        }

        //Constructors
        public Warrior()
            : this(160,100)
        {
        }


        public Warrior(int height, int weight)
            :this(height, weight, "Mack")
        {
        }

        public Warrior(int height, int weight, string name)
        {

            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            this.Age = 18;
            this.SwordWeapon = new Sword();
        }



        public void Greetings(Warrior warrior)
        {
            System.Console.WriteLine($"Greetings, {warrior.Name}!");

        }
    }

}