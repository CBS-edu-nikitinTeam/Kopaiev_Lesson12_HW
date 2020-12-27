using System;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {

            GainNewBook(out string author, out string title, out string content);
            Book book = new Book(author, title, content);
            book.Show();

            //delay
            Console.ReadKey();
        }

        static void GainNewBook(out string author, out string title, out string content)
        {
            Console.WriteLine("Please type author");
            author = Console.ReadLine();
            Console.WriteLine("Please type title");
            title = Console.ReadLine();
            Console.WriteLine("Please type book's content");
            content = Console.ReadLine();
            Console.Write("\n");
        }
    }
}
