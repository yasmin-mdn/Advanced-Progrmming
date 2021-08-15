using System.Collections.Generic;
using System.IO;
namespace  BookFinderServer
{
    public class Book
    {
        public string bookpath { get; private set; }
        public string imagepath { get; set; }
        public string Name;

        public int goodwordscount = 0;
        public int badwordscount = 0;
        public int totalwords=0;

        public List<int> goodwordsper100line = new List<int>();
        public List<int> badwordsper100line = new List<int>();

        public string[] bookcontent { get; private set; }

        public Book(string name, string bookpath, string imagepath)
        {
            this.Name = name;
            this.bookpath = bookpath;
            this.imagepath = imagepath;
            bookcontent = File.ReadAllLines(bookpath);
        }
        public Book(){}
    }
}