using Enumerations;
using Interfaces;
using System;
using Weapons;


namespace Characters.Warriors
{
    public class Warrior : Melee, ICalculator
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
        private Faction faction;
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
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            private set
            {
                this.faction = value;
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
            : this(height, weight, DEFAULT_NAME, Faction.Default)
        {
        }

        public Warrior(int height, int weight, string name, Faction faction)
        {
            IdCounter++;
            this.id = idCounter;
            this.Height = height;
            base.Weight = weight;
            base.Name = name;
            this.Faction = faction;
            base.Age = DEFAULT_AGE; 
            this.SwordWeapon = DEFAULT_SWORD_WEAPON;
            if (this.Faction == Faction.GoodGuy)
            {
                base.HealthPoints = 120;
            }
            else if (this.Faction == Faction.BadGuy)
            {
                base.HealthPoints = 100;
            }
        }


        public Warrior(int healthPoints, int weight, int age)
        
            : base(healthPoints, weight, age)
        {
            this.Height = height;
        }

        public void SpecialWarriorGreeting()
        {
            base.Greetings(base.Name);
        }


        public static void GetDefaultValues(Warrior warrior)
        {
            Console.WriteLine($"Default Height: {DEFAULT_HEIGHT}" +
                $"\nDefault Weight: {DEFAULT_WEIGHT}" +
                $"\nDefault Name: {DEFAULT_NAME}" +
                $"\nDefault Age: {DEFAULT_AGE}" +
                $"\nDefault Weapon Damage: {warrior.DEFAULT_SWORD_WEAPON.Damage}");                
        }

        public override void Move(int pauseBetweenMovements)
        {
            base.Move(pauseBetweenMovements);
            Console.WriteLine("I have moved 10 times. I am a warrior.");
        }

        public override int AddNumber(int firstNumber, int secondNumber)
        {
           return firstNumber + secondNumber;
        }
    } 

} 