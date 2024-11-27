internal class Program
{
    private static void Main(string[] args)
    {
        List<Car> cars = new List<Car>()
        {
            new Car { ID = "1", Model = "Model S", Name = "Tesla", Year = 2020 },
            new Car { ID = "2", Model = "Corolla", Name = "Toyota", Year = 2021 },
            new Car { ID = "3", Model = "Civic", Name = "Honda", Year = 2019 },
            new Car { ID = "4", Model = "Mustang", Name = "Ford", Year = 2018 },
            new Car { ID = "5", Model = "911", Name = "Porsche", Year = 2022 },
            new Car { ID = "6", Model = "X5", Name = "BMW", Year = 2020 },
            new Car { ID = "7", Model = "A4", Name = "Audi", Year = 2021 },
            new Car { ID = "8", Model = "Camry", Name = "Toyota", Year = 2020 },
            new Car { ID = "9", Model = "Model 3", Name = "Tesla", Year = 2021 },
            new Car { ID = "10", Model = "Cherokee", Name = "Jeep", Year = 2018 }
        };

        // LINQ query

        var toyotaCars = from car in cars where car.Name == "Toyota" && car.Year == 2021 select car;

        //var orderedCars = from car in cars orderby car.Year descending select car;

        // LINQ method

        var teslaCars = cars.Where(x => x.Name == "Tesla" && x.Year == 2020);

        var orderedCars = cars.OrderByDescending(x => x.Year);

        var firstCar = cars.OrderByDescending(x => x.Year == 132).FirstOrDefault();

        foreach (var car in toyotaCars)
        {
            Console.WriteLine($"ID: {car.ID}, Model: {car.Model}, Name: {car.Name}, Year: {car.Year}");
        }

        Console.WriteLine("----------------------------------------------");

        foreach (var car in teslaCars)
        {
            Console.WriteLine($"ID: {car.ID}, Model: {car.Model}, Name: {car.Name}, Year: {car.Year}");
        }

        Console.WriteLine("----------------------------------------------");

        foreach (var car in orderedCars)
        {
            Console.WriteLine($"ID: {car.ID}, Model: {car.Model}, Name: {car.Name}, Year: {car.Year}");
        }

        Console.WriteLine("----------------------------------------------");

        Console.WriteLine($"ID: {firstCar.ID}, Model: {firstCar.Model}, Name: {firstCar.Name}, Year: {firstCar.Year}");

        Console.WriteLine("----------------------------------------------");

        // si el año de todos los autos es mayor a 2020, TRUE, sino FALSE
        Console.WriteLine(cars.TrueForAll(x => x.Year > 2017));

        Console.WriteLine("----------------------------------------------");

        cars.ForEach(x => x.Year -= 100);

        cars.ForEach(car => Console.WriteLine($"ID: {car.ID}, Model: {car.Model}, Name: {car.Name}, Year: {car.Year}"));

        Console.WriteLine(cars.Exists(x => x.Model == "A4"));

        Console.WriteLine(cars.Sum(x => x.Year));

        // objetos anónimos
        // son objetos creados en memoria sin un tipo de dato especificado
        var jeepCars = from car in cars where car.Name == "Jeep" select new { car.ID, car.Year };

        var audiCars = cars.Where(x => x.Name == "Audi").Select(x => new { x.ID, x.Year });

        Console.WriteLine(jeepCars.GetType());

        Console.WriteLine(audiCars.GetType());


    }
}


internal class Car
{
    public string ID { get; set; }
    public string Model { get; set; }
    public string Name { get; set; }

    public int Year { get; set; }
}