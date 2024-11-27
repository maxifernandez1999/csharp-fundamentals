internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();
        car.Make = "Model S";
        car.Model = "Tesla";
        car.Year = 2024;
        car.Color = "RED";

        Console.WriteLine("{0} {1} {2} {3}", car.Make, car.Model, car.Year, car.Color);

        //decimal marketValue = GetMarketValue(car);

        decimal marketValue = car.DeterminateMarketValue();

        Console.WriteLine(marketValue.ToString());
    }

}

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public decimal DeterminateMarketValue()
    {
        if (Year > 1999)
        {
            return 10000.0M;
        }

        return 2000.0M;
    }
}