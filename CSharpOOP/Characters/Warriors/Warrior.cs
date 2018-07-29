using System;
using Weapons;

namespace Characters.Warriors
{
    public class Warrior
    {
        private const int DEFAULT_HEIGHT = 63;
        private const int DEFAULT_WEIGHT = 130;
        private const int DEFAULT_AGE = 18;
        private const string DEFAULT_NAME = "Aqualine";
        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();

        private static int idCounter;
        public static int IdCounter
        {
            get
            {
                return idCounter;
            }
            set
            {
                idCounter = value;
            }
        }
        private readonly int id;
        private int height;
        private int weight;
        private string name;
        private int age;
        private Sword swordWeapon;

        public int ID
        {
            get
            {
                return this.id;
            }

        }

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
            : this(DEFAULT_HEIGHT,DEFAULT_WEIGHT)
        {
        }


        public Warrior(int height, int weight)
            :this(height, weight, DEFAULT_NAME)
        {
        }

        public Warrior(int height, int weight, string name)
        {
            IdCounter++;
            this.id = idCounter;
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            this.Age = DEFAULT_AGE;
            this.SwordWeapon = DEFAULT_SWORD_WEAPON;
        }



        public void Greetings (Warrior warrior)
        {
            Console.WriteLine($"Greetings, {warrior.Name}!");

        }

        public static void GetDefaultValues(Warrior warrior)
        {
            Console.WriteLine($"Default Height: {DEFAULT_HEIGHT}" +
                $"\nDefault Weight: {DEFAULT_WEIGHT}" +
                $"\nDefault Name: {DEFAULT_NAME}" +
                $"\nDefault Age: {DEFAULT_AGE}" +
                $"\nDefault Weapon Damage: {warrior.DEFAULT_SWORD_WEAPON.Damage}");                
        }
    } 

} 