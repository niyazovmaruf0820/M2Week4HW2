namespace task3;

public abstract class AbsrtactBook : IReadable
{
    public string Title { get; set; }
    public string Author { get; set; }

    public void Read()
    {
        System.Console.WriteLine("The book is reading by someone");
    }

}
