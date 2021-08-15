using System.Collections.Generic;
using System.IO;
namespace BookFinderServer
{
    public class Finder
    {
        public static Library library = new Library();
        private static WordRepository wordRepository = new WordRepository();

        public static Book FindBook(string searchkey)
        {
            foreach (var v in library.allBookspath)
            {
                if (v.ToLower().Contains(searchkey.ToLower()))
                {
                    return new Book(v.Split('\\', '.')[1], v, "images\\" + v.Split('\\', '.')[1] + ".jpg");
                }
            }
            return new Book("notfound", null, null);
        }


        private static void Wordcount(Book book)
        {
            int linenomber = 0;
            int tempgoodwordcount = 0;
            int tempbadwordscount = 0;
            foreach (var line in book.bookcontent)
            {
                linenomber++;
                var tmp = line.Split(' ', ';', '.', '-', ',', ':', '?', '!');
                foreach (var v in tmp)
                {
                    book.totalwords++;
                    if (wordRepository.baddwords.Contains(v))
                    {
                        book.badwordscount++;
                        tempbadwordscount++;
                    }

                    if (wordRepository.goodwords.Contains(v))
                    {
                        book.goodwordscount++;
                        tempgoodwordcount++;
                    }
                }
                 if (linenomber % 100 == 0)
                        {
                            book.badwordsper100line.Add(tempbadwordscount);
                            tempbadwordscount = 0;
                            book.goodwordsper100line.Add(tempgoodwordcount);
                            tempgoodwordcount = 0;
                        }
            }

        }

        public static void Analyze(Book book)
        {
            Wordcount(book);
        }
    }
}