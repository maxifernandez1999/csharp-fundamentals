using System.Net.NetworkInformation;

public class Program
{
        //Console.WriteLine("Select an option: 1, 2 or 3 ");
    static void Main(string[] args)
    {
        //Console.WriteLine("How old are Maxi?");

        //int ageMaxi;

        //bool isAgeMaxi = int.TryParse(Console.ReadLine(), out ageMaxi);

        //int.Parse
        // -> parsea un string a int
        // OK -> retorna el valor parseado
        // ERR -> Lanza un error

        // -> Intenta parsear un string a un int
        // OK -> retorna TRUE y guarda en "out number" el valor convertido a int
        // ERR -> retorna FALSE y no escribe sobre la variable "out number"
        //int.TryParse(string, out number)

        //Console.WriteLine("How old are Pablo?");

        //int agePablo;

        //bool isAgePablo = int.TryParse(Console.ReadLine(), out agePablo);

        //int sum = agePablo + ageMaxi;

        //Console.WriteLine("The sum of the Maxi's age and Pablo's age is: " + sum);


        //string? option = Console.ReadLine();

        //if (option == "1")
        //    Console.WriteLine("You select option 1");
        //else if (option == "2")
        //    Console.WriteLine("You select option 2");
        //else if (option == "3")
        //    Console.WriteLine("You select option 3");
        //else
        //    Console.WriteLine("Error");
    
        //string message = (option == "1") ? "Yor won" : "You are so bad";
        //Console.WriteLine("You select option {0}. {1}", option, message);

        //for

        //for (int i = 0; i < 10; i++)
        //{
        //    if (i == 7)
        //    {
        //        continue;
        //    }

        //    Console.WriteLine(i);

        //}


        //int[] num = new int[5];

        //num[0] = 2;
        //num[1] = 3;
        //num[2] = 4;
        //num[3] = 5;
        //num[4] = 6;


        //Console.WriteLine(num[4]);

        //string[] names = new string[] { "Maxi", "Pablo", "Miriam" };

        //Console.WriteLine(names[2]);

        //for (int i = 0; i < num.Length; i++)
        //{
        //    Console.WriteLine(num[i]);

        //}

        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}

        //string name = "Maximiliano Fernandez";

        //char[] chars = name.ToCharArray();

        //Array.Reverse(chars);

        //Array.Sort(chars);

        //Console.WriteLine(chars);


        //foreach (var charStr in chars)
        //{
        //    Console.WriteLine(charStr);    
        //}

        string firstName = " Maximiliano";
        string lastName = "Fernandez";

        string[] fullname = new string[] { lastName, firstName }; 

        //Console.WriteLine(GetFullName(firstName, lastName));

        Console.WriteLine(String.Join(',',fullname));  

    }

    private static string GetFullName(string firstName, string lastName)
    {
        return String.Format("{0} {1}", firstName, lastName);

        
    }
}