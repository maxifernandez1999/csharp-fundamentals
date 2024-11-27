using CodeLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Scrape scrape = new Scrape();
        string value = scrape.ScrapeWebPage("http://msdn.microsoft.com");
        Console.WriteLine(value);
        Console.ReadLine();
    }
}