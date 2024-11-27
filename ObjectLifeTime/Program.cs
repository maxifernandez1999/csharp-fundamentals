using Microsoft.Win32;

internal class Program
{
    // Los objetos son tipos de datos por referencia
    // Guardan la dirección de memoria donde se encuentra el objeto
    private static void Main(string[] args)
    {
        // Cuando se instancia el objeto se guarda la direccion en memoria en la variable
        Car car = new Car("Model S", "Tesla", 2024, "RED");

        // Copio la dirección de memoria en el nuevo objeto
        // como apuntan a la misma dirección, cuando modifico una prop, cambia en ambos objetos
        Car myNewCar = car;

        car.Year = 2020;

        Car.StaticMethod();


        Console.WriteLine("{0} {1} {2} {3}", myNewCar.Make, myNewCar.Model, myNewCar.Year, myNewCar.Color);

        Console.WriteLine("{0} {1} {2} {3}", car.Make, car.Model, car.Year, car.Color);

    }

}

class Car
{
    public string Make { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public string? Color { get; set; }


    public Car()
    {
        this.Make = "Tesla";
    }

    public Car(string make, string model, int year, string color)
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.Color = color;
    }

    public decimal DeterminateMarketValue()
    {
        if (Year > 1999)
        {
            return 10000.0M;
        }

        return 2000.0M;
    }

    public static void StaticMethod()
    {
        Console.WriteLine("This is a static method");
    }
}