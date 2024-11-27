using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string strBackslash = "Hello \"World\"";

        string str_n = "Hello\nWorld";

        string literal = @"c:\ drive";

        string format = String.Format("{0}, {1}", strBackslash, literal);

        string currency = String.Format("{0:C}", 230.34);

        string largeNumber = String.Format("{0:N}", 1234567890);

        string percentage = String.Format("{0:P}", .5);

        string phone = String.Format("{0:(+##) ##########}", 541138202341);


        string phrase = "Hello world";

        phrase = phrase.Substring(3);
        phrase = phrase.ToUpper();
        phrase = phrase.Replace(" ", "-");

        phrase = phrase.Remove(0, 3);

        string whiteSpaces = "   Hola    ";

        whiteSpaces = whiteSpaces.Trim(); 


        // Trabajar con string de manera mas eficiente
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < 50 ; i++)
        {
            stringBuilder.Append("--");
            stringBuilder.Append(i);
        }

        //
        Console.WriteLine(stringBuilder);

        Console.WriteLine(whiteSpaces);

        Console.WriteLine(phrase);



        Console.WriteLine(strBackslash);
        Console.WriteLine(str_n);
        Console.WriteLine(literal);
        Console.WriteLine(format);
        Console.WriteLine(currency);
        Console.WriteLine(largeNumber);
        Console.WriteLine(percentage);
        Console.WriteLine(phone);






        Console.ReadLine(); 
    }
}