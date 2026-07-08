class Program
{
    static void Main()
    {
        Book Dune = new Book("Dune", "Frank Herbet", 1);
        Book Gobbles = new Book("Dune", "Frank Herbet", 1);
        User Sarah = new User("Sarah");

        Dune.Borrow(Sarah); 
        Console.WriteLine(Sarah.NumOfBorrowedBooks());
        Dune.Borrow(Sarah);
        Dune.Return(Sarah);

    }
}

class Book
{
    public string bookTitle;
    private string bookAuthor;
    private int copiesTotal;
    private int copiesAvailable;
    private Dictionary<string, DateOnly> userList = new Dictionary<string, DateOnly>();

    public Book(string title, string author, int totalBooks)
    {
        bookTitle = title;
        bookAuthor = author;
        copiesTotal = totalBooks;
        copiesAvailable = totalBooks;
        Console.WriteLine($"{copiesTotal} copies of {bookTitle} by {bookAuthor} have been added to inventory.");
    }

    public void Borrow(User user)
    {
        if (copiesAvailable != 0 && !userList.ContainsKey(user.userName))
        {
            copiesAvailable -= 1;

            DateOnly borrowDate = new DateOnly(2026, 5, 1);
            user.LogBookBorrowed(bookTitle, borrowDate);
            userList.Add(user.userName, borrowDate);

            Console.WriteLine($"{user.userName} has checked out with {bookTitle}. There are {copiesAvailable} of copies left.");
        }
        else if (userList.ContainsKey(user.userName))
        {
            Console.WriteLine($"{user.userName} has already taken out a copy of {bookTitle}");
        }
        else
        {
            Console.WriteLine($"There are no available copies of {bookTitle} left!");
        }
    }
    public void Return(User user)
    {
        if (user.GetBorrowDate(bookTitle) < DateOnly.FromDateTime(DateTime.Now).AddDays(-15))
        {
            Console.WriteLine($"{user.userName} has returned {bookTitle}, it was overdue.");
        }
        else
        {
            Console.WriteLine($"{user.userName} has returned {bookTitle} on time.");
        }
        copiesAvailable++;
        user.LogBookReturned(bookTitle);
    }
}

class User
{
    public string userName;
    private Dictionary<string,DateOnly> userBooks = new Dictionary<string, DateOnly>();
    public User(string name)
    {
        userName = name;
    }
    public void LogBookBorrowed(string title, DateOnly date)
    {
        userBooks.Add(title, date);
    }
    public void LogBookReturned(string title)
    {
        userBooks.Remove(title);
    }
    public DateOnly GetBorrowDate(string title)
    {
        return userBooks[title];
    }
    public int NumOfBorrowedBooks()
    {
        return userBooks.Count;
    }

}
