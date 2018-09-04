

using System;
using Characters.Warriors;
using Interfaces;
using CSharpOOP.Weapons;

namespace Characters.Spellcasters
{
    public class Mage : Character, ICalculator, ISpellcaster
    {
        private int mana;
        private Spell mySpell;
        public override int Age
        {
            get
            {
                return this.Age;
            }
            set
            {
                if (value >= 30 && value <= 60)
                {
                    this.Age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Mages need to be between the ages of 30 and 60.");
                }
            }
        }


        public int Mana
        {
            get
            {
                return this.mana;
            }

            set
            {
                this.mana = value;
            }
        }
        public Spell MySpell
        {
            get
            {
                return this.mySpell;
            }
            set
            {
                this.mySpell = value;
            }
        }

        public Mage()
        {
            this.Mana = 100;
            this.MySpell = new Spell();
        }

        public Mage (int healthPoints, int weight, int age)

            : base(healthPoints, weight, age)
        {

        }

        public override void Move(int pauseBetweenMovements)
        {
            base.Move(pauseBetweenMovements);
            System.Console.WriteLine("I have moved. I am a Mage.");
        }

        public void AddNumber(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            int modifiedSum = sum + 123;
            Console.WriteLine(modifiedSum - 123);
        }

        public void CastSpell(Warrior warrior)
        {
            warrior.HealthPoints = warrior.HealthPoints - this.mySpell.Damage;
            this.mana = this.mana - this.mySpell.ManaCost;
        }
    }
}
