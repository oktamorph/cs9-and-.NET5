// See https://aka.ms/new-console-template for more information
#nullable enable

string authorName = null;
int x = authorName.Length;
int? y = authorName?.Length;

var result = authorName?.Length ?? 3;
Console.WriteLine(result);

var address = new Address();
address.Building = null;
address.Street = null;
address.City = "London";
address.Region = null;

class Address
{
    public string? Building;
    public string Street = string.Empty;
    public string City = string.Empty;
    public string Region = string.Empty;
}
