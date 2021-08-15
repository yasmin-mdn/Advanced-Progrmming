using System;

namespace BookFinderServer
{
    class Program
    {
        static void Main(string[] args)
        {
           var book= Finder.FindBook("sand");
           System.Console.WriteLine(book.Name);
           System.Console.WriteLine(book.bookpath);
           System.Console.WriteLine(book.imagepath);
           System.Console.WriteLine(book.bookcontent);
           Finder.Analyze(book);
           System.Console.WriteLine(book.badwordscount);
           System.Console.WriteLine(book.goodwordscount);
            System.Console.WriteLine("//////");
            System.Console.WriteLine(book.totalwords);
          /* foreach(var v in book.badwordsper100line)
           System.Console.WriteLine(v);
           System.Console.WriteLine("//////");
           foreach(var v in book.goodwordsper100line)
             System.Console.WriteLine(v);*/
        }
    }
}
