using System;
using PacktLibrary;

namespace PeopleApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var harry = new Person { Name = "Harry" };
            var mary = new Person { Name = "Mary" };
            var jill = new Person { Name = "Jill" };

            var baby1 = mary.ProcreateWith(harry);
            baby1.Name = "Gary";

            var baby2 = Person.Procreate(harry, jill);

            // call an operator
            var baby3 = harry * mary;

            Console.WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            Console.WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            Console.WriteLine($"{jill.Name} has {jill.Children.Count} children.");
            Console.WriteLine(format: "{0}'s first child is named \"{1}\".",
                arg0: harry.Name,
                arg1: harry.Children[0].Name);

            Console.WriteLine($"5! is {Person.Factorial(5)}");

            harry.Shout += Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

            Person[] people =
            {
                new Person {Name = "Simon" },
                new Person {Name = "Jenny" },
                new Person {Name = "Adam" },
                new Person {Name = "Richard" }
            };

            Console.WriteLine("Initial list of people:");
            foreach (var person in people)
            {
                Console.WriteLine($" {person.Name}");
            }

            Console.WriteLine("Use Person's IComparable implementation to sort:");
            Array.Sort(people);
            foreach (var person in people)
            {
                Console.WriteLine($" {person.Name}");
            }

            Console.WriteLine("Use PersonComparer's IComparer implementation to sort:");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                Console.WriteLine($" {person.Name}");
            }

            var t1 = new Thing();
            t1.Data = 42;
            Console.WriteLine($"Thing with an integer: {t1.Process(42)}");

            var t2 = new Thing();
            t2.Data = "apple";
            Console.WriteLine($"Thing with a string: {t2.Process("apple")}");

            var gt1 = new GenericThing<int>();
            gt1.Data = 42;
            Console.WriteLine($"GenericThing with an integer: {gt1.Process(42)}");

            var gt2 = new GenericThing<string>();
            gt2.Data = "apple";
            Console.WriteLine($"GenericThing with a string: {gt2.Process("apple")}");

            string number1 = "4";
            Console.WriteLine("{0} squared is {1}", arg0: number1, arg1: Squarer.Square<string>(number1));

            byte number2 = 3;
            Console.WriteLine("{0} squared is {1}", arg0: number2, arg1: Squarer.Square(number2));
        }
        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            Console.WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
        }
    }
}
