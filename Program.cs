using System;

namespace Andre_x2___under_x1
{
    class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books();
            Console.WriteLine("What is the name of the book?");

            books.name = Console.ReadLine();

            Console.WriteLine("When was the release date?");

            books.date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many pages are in the book?");

            books.pages = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the name of the Author?");

            books.authour = Console.ReadLine();

            Console.WriteLine("The book is", books.name);
            Console.WriteLine("The Date it came out was", books.date);
            Console.WriteLine("The Amount of pages are", books.pages);
            Console.WriteLine("The authour is", books.authour);
        ;
        }
    }
}
