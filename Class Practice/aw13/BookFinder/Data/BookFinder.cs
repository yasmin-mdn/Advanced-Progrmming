using System.Collections.Generic;
using System.IO;

namespace BookFinder.Data
{
    class Book
    {
        private string Name { get; set; }
        private static string[] booksname;
        private static string[] booksImagename;

        public static string  MyReadallltext{get;private set;} 
        
        public static List<int> posetivewordsper100line=new List<int>();
        public static List<int> negetivewordsper100line=new List<int>();
        private static List<string> pwords=new List<string>();
        private static List<string> nwords=new List<string>();

        public static void GetFilesFromDirectories()
        {
            Book.booksname = Directory.GetFiles("Data\\books");
            Book.booksImagename = Directory.GetFiles("Data\\images");

        }
        public static string FindBook(string searchkey)
        {
            string name = null;
            foreach (string n in booksname)
            {
                if (n.ToLower().Contains(searchkey.ToLower()))
                    name = n;
            }
            return name;
        }

        public static string FindBookImage(string searchkey)
        {
            string imagename = null;
            foreach (string i in booksImagename)
            {
                if (i.ToLower().Contains(searchkey.ToLower()))
                    imagename = i;
            }
            return imagename;
        }


        public static int IndexFile(string bookpath){//////return nomber of total words
            MyReadallltext=File.ReadAllText(bookpath);
            var tokens=MyReadallltext.Split(' ',';','.','-',',',':','?','!');
            return tokens.Length;

         }
           
        public static void CountPandN(string bookpath){///count + and - per 100lines stor in 2lists 
            posetivewordsper100line.Clear();
            negetivewordsper100line.Clear();
            int countp=0;
            int countn=0;
            int linecount=0;
            var lines = File.ReadAllLines(bookpath);
            for(int i=0;i<lines.Length;i++){
                linecount+=1;
                foreach(var word in lines[i].Split(' ',';','.','-',',',':','?','!')){
                    if(pwords.Contains(word)){
                        countp+=1;
                    }
                    else if(nwords.Contains(word)){
                        countn+=1;
                    }
        
                    if (linecount%100==0 ||linecount==lines.Length){
                        posetivewordsper100line.Add(countp);
                        negetivewordsper100line.Add(countn);
                        countn=0;
                        countp=0;
                    }
                }
            }

            
        }

        public static void GetPosetiveAndNegetiveWords(string bookpath){
            foreach(var v in File.ReadAllLines("Data\\words\\positive-words.txt")){
                pwords.Add(v);
            } 
            foreach (var v in File.ReadAllLines("Data\\words\\negative-words.txt")){
                nwords.Add(v);
            }
        }

        

        
           
        
        public static string First50Words(string bookpath)
        {
           string content ="";
            int counter = 0;
            var lines = File.ReadAllLines(bookpath);
            foreach (var word in lines)
            {
                if (!string.IsNullOrWhiteSpace(word))
                    counter++;
                content+=word;
                if (counter == 50)
                    break;
            }
            return content;
        }
    }
}