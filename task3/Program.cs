using task3;

Book book = new Book();
book.Title = "Harry Potter";
book.Author = "Abbuadulloh Rudaki";
System.Console.WriteLine(book.Title);
System.Console.WriteLine(book.Author);
book.Read();
book.Borrow();
book.ReturnBook();