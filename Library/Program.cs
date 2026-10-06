using Library;

static void Main(string[] args)
{
    //Create a new instance (object) of the Book class
    //Note how the object name differs from the class name
    Book book = new Book("C# for beginners", "BillGates", "12345678");

    book.DisplayInfo();
}