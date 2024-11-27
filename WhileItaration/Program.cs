internal class Program
{
    private static void Main(string[] args)
    {
        bool exit = false;
        

        do
        {
            int option = PrintMainManu();
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine()!);

            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine()!);

            if (option == 1)
            {
                Console.WriteLine(Add(firstNumber, secondNumber));
                Console.ReadKey();
                Console.Clear();
            }
            else if (option == 2)
            {
                Console.WriteLine(Substract(firstNumber, secondNumber));
                Console.ReadKey();
                Console.Clear();
            }
            else if (option == 3)
            {
                Console.WriteLine(Multiply(firstNumber, secondNumber));
                Console.ReadKey();
                Console.Clear();

            }
            else if (option == 4)
            {
                Console.WriteLine(Division(firstNumber, secondNumber));
                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                exit = true;
            }


        } while (!exit);
       
    }

    private static int PrintMainManu()
    {
        Console.WriteLine("CALCULATOR: ");
        Console.WriteLine("#############");
        Console.WriteLine("Choose an option: ");
        Console.WriteLine("1. +");
        Console.WriteLine("2. -");
        Console.WriteLine("3. *");
        Console.WriteLine("4. /");
        Console.WriteLine("5. Exit");

        return int.Parse(Console.ReadLine()!);
    }


    private static int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    private static int Substract(int number1, int number2)
    {
        return number1 - number2;
    }

    private static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    private static int Division(int number1, int number2)
    {
        return number1 / number2;
    }
}