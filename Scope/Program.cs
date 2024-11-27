internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();
        //accesible desde toda la solución
        car.PublicMethod();

        //accesible solo desde la clase donde esta definida
        //car.PrivateMethod();

        //accesible solo dentro del mismo proyecto
        //car.InternalMethod();

        //accesible desde la clase donde esta definida y clases derivadas
        TestCar test = new TestCar();
        test.CallProtectedMethod();
    }
}
class TestCar : Car
{
    public void CallProtectedMethod()
    {
        ProtectedMethod(); // Esto es válido porque TestCar hereda de Car
    }
}
class Car
{

    public void PublicMethod()
    {
        Console.WriteLine("PUBLIC!");
    }

    public void ShowPrivateMethod()
    {
        Console.WriteLine(PrivateMethod());
    }

    private string PrivateMethod()
    {
        return "PRIVATE!";
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("PROTECTED!");
    }

    internal void InternalMethod()
    {
        Console.WriteLine("INTERNAL!");
    }
}