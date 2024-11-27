internal class Program
{
    private static void Main(string[] args)
    {
        DateTime dateTime = DateTime.Now;
        string dateShort = dateTime.ToShortDateString();
        string dateLong = dateTime.ToLongDateString();
        string timeShort = dateTime.ToShortTimeString();
        string timeLong = dateTime.ToLongTimeString();

        Console.WriteLine(dateTime.ToString());
        Console.WriteLine(dateShort.ToString());
        Console.WriteLine(dateLong.ToString());
        Console.WriteLine(timeShort.ToString());
        Console.WriteLine(timeLong.ToString());

        string dateTimeAdd = dateTime.AddDays(3).ToString();
        string dateTimeSubtract = dateTime.AddDays(-3).ToString();


        Console.WriteLine(dateTimeAdd);
        Console.WriteLine(dateTimeSubtract);

        DateTime myBirthday = new DateTime(1999,10,7);

        Console.WriteLine(myBirthday.ToShortDateString());

        DateTime myBirthDayString = DateTime.Parse("07/10/1999");
        
        Console.WriteLine(myBirthDayString.ToShortDateString());

        //TimeSpan -> obtiene un intervalo de tiempo
        TimeSpan myAge = dateTime.Subtract(myBirthday);

        Console.WriteLine(myAge.TotalDays);

        Console.ReadKey();
    }
}