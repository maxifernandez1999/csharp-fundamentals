internal class Program
{
    private static void Main(string[] args)
    {
		try
		{
            string content = File.ReadAllText(@"C:\Users\MaximilianoFernandez\Desktop\Git\qa.txt");
            Console.WriteLine(content);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("No se encuentra el directorio: {0}",ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("No se encuentra el archivo: {0}", ex.Message);
        }
        catch (Exception ex)
		{
            Console.WriteLine(ex.StackTrace);
        }
        finally
        {
            Console.WriteLine("Finalizando app...");
        }

        Console.ReadLine(); 
    }
}