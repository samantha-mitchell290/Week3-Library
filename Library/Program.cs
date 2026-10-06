using Library;

class Program
{
    static void Main(string[] args)
    {
        //Create a new instance (object) of the Book class
        //Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "BillGates", "12345678");
        Book book1 = new Book("Ultimate C#", "Microsoft", "2233445");

        book.DisplayInfo();
        book1.DisplayInfo();
    }
}
