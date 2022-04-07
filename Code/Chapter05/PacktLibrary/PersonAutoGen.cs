namespace Packt.Shared
{
    public partial class Person
    {
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }
        public string Greeting => $"{Name} says 'Hello!'";
        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;
        public string FavoriteIceCream { get; set; }
        private string _favoritePrimaryColor;
        public string FavoritePrimaryColor
        {
            get { return _favoritePrimaryColor; }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        _favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException($"{value} is not a primary color. " +
                            "Choose from: red, green, blue.");
                }
            }
        }
        // indexers
        public Person this[int index]
        {
            get { return Children[index]; }
            set { Children[index] = value; }
        }
    }
}
