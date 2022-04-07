using Packt.Shared;

var bob = new Person();
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.FavoriteAncientWonders = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

Console.WriteLine(
    format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: bob.Name,
    arg1: bob.DateOfBirth);

Console.WriteLine("{0}'s favorite wonder is {1}. Its integer is {2}.",
    arg0: bob.Name,
    arg1: bob.FavoriteAncientWonders,
    arg2: (int)bob.FavoriteAncientWonders);

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

Console.WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new Person { Name = "Zoe" });

Console.WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for (int child = 0; child < bob.Children.Count; child++)
{
    Console.WriteLine($" {bob.Children[child].Name}");
}

Console.WriteLine($"{bob.Name} is a {Person.Species}");
Console.WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

bob.WriteToConsole();
Console.WriteLine(bob.GetOrigin());

Console.WriteLine();

var alice = new Person
{
    Name = "Alice Jones",
    DateOfBirth = new DateTime(1998, 3, 7)
};

Console.WriteLine(
    format: "{0} was born on {1:dd MMM yy}",
    arg0: alice.Name,
    arg1: alice.DateOfBirth);

Console.WriteLine();

BankAccount.InterestRate = 0.012M; // store a shared value

var jonesAccount = new BankAccount();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;

Console.WriteLine(format: "{0} earned {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate);

var gerrierAccount = new BankAccount();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;

Console.WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance * BankAccount.InterestRate);

Console.WriteLine();

var blankPerson = new Person();
Console.WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instatiated);

var gunny = new Person("Gunny", "Mars");
Console.WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: gunny.Name,
    arg1: gunny.HomePlanet,
    arg2: gunny.Instatiated);

(string, int) fruit = bob.GetFruit();
Console.WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

var fruitNamed = bob.GetNamedFruit();
Console.WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

var thing1 = ("Neville", 4);
Console.WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

var thing2 = (bob.Name, bob.Children.Count);
Console.WriteLine($"{thing2.Name} jas {thing2.Count} children.");

(string fruitName, int fruitNumber) = bob.GetFruit();
Console.WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

Console.WriteLine();

Console.WriteLine(bob.SayHello());
Console.WriteLine(bob.SayHello("Emily"));

Console.WriteLine(bob.OptionalParameters());
Console.WriteLine(bob.OptionalParameters("Jump!", 98.5));
Console.WriteLine(bob.OptionalParameters(number: 52.7, command: "Hide!"));
Console.WriteLine(bob.OptionalParameters("Poke!", active: false));

Console.WriteLine();

int a = 10;
int b = 20;
int c = 30;

Console.WriteLine($"Before: a = {a}, b = {b}, c = {c}");
bob.PassingParameters(a, ref b, out c);
Console.WriteLine($"After: a = {a}, b = {b}, c = {c}");

int d = 10;
int e = 20;

Console.WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");
bob.PassingParameters(d, ref e, out int f);
Console.WriteLine($"After: d = {d}, e = {e}, f = {f}");

Console.WriteLine();

var sam = new Person
{
    Name = "Sam",
    DateOfBirth = new DateTime(1972, 1, 27)
};

Console.WriteLine(sam.Origin);
Console.WriteLine(sam.Greeting);
Console.WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
Console.WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
sam.FavoritePrimaryColor = "Red";
Console.WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");

Console.WriteLine();

sam.Children.Add(new Person { Name = "Charlie" });
sam.Children.Add(new Person { Name = "Ella" });

Console.WriteLine($"Sam's first child is {sam.Children[0].Name}");
Console.WriteLine($"Sam's second child is {sam.Children[1].Name}");

Console.WriteLine($"Sam's first child is {sam[0].Name}");
Console.WriteLine($"Sam's second child is {sam[1].Name}");

Console.WriteLine();

object[] passengers =
{
        new FirstClassPassenger{AirMiles = 1_419 },
        new FirstClassPassenger{AirMiles = 16_562 },
        new BusinessClassPassenger(),
        new CoachClassPassenger{CarryOnKG = 25.7 },
        new CoachClassPassenger{CarryOnKG = 0 }
    };

foreach (object passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        // C# 8 syntax
        //FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        //FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        //FirstClassPassenger _ => 2000M,

        // C# 9 syntax
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35000 => 1500M,
            > 15000 => 1750M,
            _ => 2000M
        },
        BusinessClassPassenger _ => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };

    Console.WriteLine($"Flight costs {flightCost:C} for {passenger}");

    Console.WriteLine();

    var jeff = new ImmutablePerson
    {
        FirstName = "Jeff",
        LastName = "Winger"
    };

    // jeff.FirstName = "Geoff";
    Console.WriteLine();

    var car = new ImmutableVehicle
    {
        Brand = "Mazda MX-5 RF",
        Color = "Soul Red Crystal Metallic",
        Wheels = 4
    };

    var repaintedCar = car with { Color = "Polymetal Grey Metallic" };
    Console.WriteLine("Original color was {0}, new color is {1}",
        arg0: car.Color, arg1: repaintedCar.Color);

    Console.WriteLine();

    var oscar = new ImmutableAnimal("Oscar", "Labrador");
    var (who, what) = oscar;
    Console.WriteLine($"{who} is a {what}.");
}
