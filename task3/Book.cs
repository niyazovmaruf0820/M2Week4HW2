namespace task3;

public class Book : AbsrtactBook, IBorrowable
{
    public void Borrow()
    {
        System.Console.WriteLine("The book is already rented");
    }

    public void ReturnBook()
    {
        System.Console.WriteLine("The book is already returned to his owner");
    }
}
