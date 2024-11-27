internal class Program
{
    private static void Main(string[] args)
    {
        List<Todo> todoList = new List<Todo>()
        {
            new Todo {Description = "Task1", EstimatedHours = 6, Status = Status.Active},
            new Todo {Description = "Task2", EstimatedHours = 6, Status = Status.InProgress},
            new Todo {Description = "Task3", EstimatedHours = 6, Status = Status.PullRequest},
            new Todo {Description = "Task4", EstimatedHours = 6, Status = Status.Closed},
        };

        Print(todoList);
    }

    public static void Print(List<Todo> todoList)
    {
        foreach (Todo todo in todoList)
        {
            switch (todo.Status)
            {
                case Status.Active:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Status.InProgress:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Status.PullRequest:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case Status.Closed:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    break;
            }

            Console.WriteLine(todo.Description);

        }
    }
}

internal class Todo
{
    public string Description { get; set; }
    public int EstimatedHours { get; set; } 
    public Status Status  { get; set; }
}

enum Status
{
    Active,
    InProgress,
    PullRequest,
    Closed
}