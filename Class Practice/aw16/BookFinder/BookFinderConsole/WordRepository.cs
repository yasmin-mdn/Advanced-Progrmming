using System;
using System.Collections.Generic;
using System.IO;

namespace BookFinderServer{
    class WordRepository{
        public HashSet<string> goodwords=new HashSet<string>();
        public HashSet<string> baddwords=new HashSet<string>();

        public WordRepository()
        {
            this.goodwords =new HashSet<string>(File.ReadAllLines("words\\positive-words.txt")) ;
            this.baddwords = new HashSet<string>(File.ReadAllLines("words\\negative-words.txt")) ;
        }
    }
}