using System.Runtime.CompilerServices;

internal class Program
{
    // programación orientada a eventos
    private static void Main(string[] args)
    {
        System.Timers.Timer timer = new System.Timers.Timer(500);

        // me subscribo al evento
        timer.Elapsed += Timer_Elapsed1;
        timer.Elapsed += Timer_Elapsed2;


        timer.Start();

        Console.WriteLine("Presiona Enter para apagar evento 2...");
        Console.ReadLine();

        // me desubscribo al evento
        timer.Elapsed -= Timer_Elapsed2;
        Console.WriteLine("Presiona Enter para salir...");

        Console.ReadLine();



    }

    private static void Timer_Elapsed1(object? sender, System.Timers.ElapsedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("{0}", e.SignalTime);
    }


    private static void Timer_Elapsed2(object? sender, System.Timers.ElapsedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("{0}", e.SignalTime);
    }

}