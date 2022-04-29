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
        }
        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            Console.WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
        }
    }
}
