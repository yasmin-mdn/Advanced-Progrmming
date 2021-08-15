using System;
using System.Collections.Generic;
using System.IO;

namespace c6cs
{
    public class TextIndex
    {
        private string dirname;
        int i=0;
      private  Dictionary<string,List<string>> dict;

        public TextIndex(string dirName)
        {this.dirname=@"C:\git\AP98992\class\c6\"+dirName;
        this.dict=new Dictionary<string, List<string>>();
        string[] files=Directory.GetFiles(this.dirname);
        foreach(var f in files){
           buildindex(f);
           Console.WriteLine($"add {f} to index");
        }
         
        }

       public int Quary(string quary)
        {
            foreach(var d in this.dict){
                if(d.Key.ToLower()==quary.ToLower())
                this.i++;
            }
            return this.i;
        }

        private HashSet<string> makehash(string[] tokens){
            HashSet<string> result=new HashSet<string>();
            foreach(var tok in tokens){
                if(!result.Contains(tok)){
                    result.Add(tok);
                }
            }
           
            return result;
        }


        internal void buildindex(string file)
        {HashSet<string> token=new HashSet<string>();
          string[] tokens=File.ReadAllText(file).Split(' ' ,',' ,':' ,'(','\n','[',']','(',')','?','.','\t');

                token=makehash(tokens);
                foreach(var t in token){
                    if(!string.IsNullOrWhiteSpace(t)){
                     if(!this.dict.ContainsKey(t))   {
                         this.dict.Add(t,new List<string>());
                     }
                     this.dict[t].Add(file);

                    }
                }

        }
    }
}