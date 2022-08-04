using System;
using System.Collections.Generic;

namespace PacktLibrary
{
    public class Person : IComparable<Person>
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();
        public event EventHandler Shout;
        public int AngerLevel;
        // methods
        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }
        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;
        }
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }
        public static Person operator *(Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }
        /// <summary>
        /// Method with a local function.
        /// </summary>
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{nameof(number)} cannot be less than zero.");
            }
            return LocalFactorial(number);

            int LocalFactorial(int localnumber) // local function
            {
                if (localnumber < 1) return 1;
                return localnumber * LocalFactorial(localnumber - 1);
            }
        }/// <summary>
         /// Method.
         /// </summary>
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                // if something is listening...
                Shout?.Invoke(this, EventArgs.Empty);
            }
        }

        public int CompareTo(Person? other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}