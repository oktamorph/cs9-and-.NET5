try
{
    checked
    {
        int x = int.MaxValue - 1;
        Console.WriteLine($"Initial value: {x}");
        x++;
        Console.WriteLine($"After incrementing: {x}");
        x++;
        Console.WriteLine($"After incrementing: {x}");
        x++;
        Console.WriteLine($"After incrementing: {x}");
    }
    unchecked
    {
        int y = int.MaxValue + 1;
        Console.WriteLine($"Initial valie: {y}");
        y--;
        Console.WriteLine($"After decrementing: {y}");
        y--;
        Console.WriteLine($"After decrementing: {y}");
    }
}
catch (OverflowException)
{
    Console.WriteLine("The code overflowed but I caught the exception.");
}
