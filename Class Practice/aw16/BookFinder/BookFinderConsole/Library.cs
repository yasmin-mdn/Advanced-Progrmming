using System.Collections.Generic;
using System.IO;
namespace BookFinderServer{
    public class Library{
        public  string[] allBookspath{get;private set;}
        public  string[] allimagespath{get;private set;}
        

        public Library()
        {
            GetFilesFromDirectories();
        }

        private void GetFilesFromDirectories()
        {
            allBookspath = Directory.GetFiles("books");
            allimagespath = Directory.GetFiles("images");

        }
    }
}