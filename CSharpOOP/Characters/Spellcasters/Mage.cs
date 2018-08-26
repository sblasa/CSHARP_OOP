

using System;

namespace Characters.Spellcasters
{
    public class Mage : Character
    {

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


        public Mage()
        {

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
    }
}
