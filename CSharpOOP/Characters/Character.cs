
using Interfaces;
using System;
using System.Threading;

namespace Characters
{
    public abstract class Character : ICalculator
    {
        private int healthPoints;
        private int weight;
        private int age;
        private string name;

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }
        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }
        public virtual int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value >= 18 && value <= 45)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Warriors need to be between the ages of 18 and 45.");
                }
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

        public Character()
        {

        }

        public Character(int healthPoints, int weight, int age)
        {
            this.HealthPoints = healthPoints;
            this.Weight = weight;
            this.Age = age;
        }

        protected void Greetings(string name)
        {
            Console.WriteLine($"Greetings, {this.Name}!");

        }

        public virtual void Move(int pauseBetweenMovements)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I am moving.");
                Thread.Sleep(pauseBetweenMovements);
            }
        }
        public abstract void AddNumber(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }

    }
}
