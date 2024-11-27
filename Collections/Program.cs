internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * List -> type of collection
         */

        // Inicializacion
        /*
            Car car = new Car();
            car.ID = "A1";
            car.Model = "Tesla";
            car.Name = "Model S";
        
            List<Car> cars = new List<Car>();

            cars.Add(car);
        */

        // Inicializacion simplificada

        List<Car> cars = new List<Car>()
        {
            new Car { ID = "A1", Model = "Tesla", Name = "Model S"}
        };

        foreach (Car c in cars)
        {
            Console.WriteLine("{0} - {1} - {2}", c.ID, c.Model, c.Name);
        }


        /*
         * Dictionary -> type of collection
         */

        /*
            Dictionary<string, Car> dict = new Dictionary<string, Car>();

            dict["A1"] = new Car { Model = "Tesla", Name = "Model S" };
            dict["B2"] = new Car { Model = "Ford", Name = "K" };

            Console.WriteLine("{0} - {1} - {2}", dict["A1"].ID, dict["A1"].Model, dict["A1"].Name);
         */



        Console.ReadLine(); 
    }

}

internal class Car
{
    public string ID { get; set; }
    public string Model { get; set; }
    public string Name { get; set; }
}