using System;
using System.Collections.Generic;
using System.IO;

namespace A3_cs
{
    class Program
    {
      

        private static void MakeOutputOf(string directory_name)
        { 
            string[] allfiles=Directory.GetFiles(directory_name);
            foreach(var file in allfiles){
               InitLines(file);
            }




        }//end  func make

////////// seprate words
    private static void InitLines(string file){
   
        List<string> line1=new List<string>();
        List<string> line2=new List<string>();
        List<string> line3=new List<string>();
        List<string> line4=new List<string>();
        List<string> line5=new List<string>();
        List<string> line6=new List<string>();
        string[] lines=File.ReadAllLines(file);
        string[] tokFirstLine=lines[0].ToLower().Split(' ',',','.');
        string[] toksecondline=lines[1].ToLower().Split(':','-',' ');
        string[] tokthirdline=lines[2].ToLower().Split(':',' ');
        string[] tokforthline=lines[3].ToLower().Split(':',',',' ');
        string[] tokfifthline=lines[4].ToLower().Split(':',',',' ');
        string[] toksixthline=lines[5].ToLower().Split(':',',',' ');
        //////////filing line 1to 6 list
            foreach(var t in tokFirstLine){
                if(!string.IsNullOrWhiteSpace(t))
                    line1.Add(t);
            }
             foreach(var t in toksecondline){
                if(!string.IsNullOrWhiteSpace(t))
                     line2.Add(t);   
            }
             foreach(var t in tokthirdline){
                if(!string.IsNullOrWhiteSpace(t))
                line3.Add(t);
             }
             foreach(var t in tokforthline){
                if(!string.IsNullOrWhiteSpace(t))
                line4.Add(t);
            }
             foreach(var t in tokfifthline){
                if(!string.IsNullOrWhiteSpace(t))
               line5.Add(t);
            }
             foreach(var t in toksixthline){
                if(!string.IsNullOrWhiteSpace(t))
                line6.Add(t);
            }
            ///////////

            //////defining dictionaries
        ////<coded,decoded>
        Dictionary <char,char> letters_dict=new Dictionary<char, char>(26);

        ////<coded,decoded>
        Dictionary  <int,int> nom_dict=new Dictionary<int, int>(10){
            {0,0},{1,0},{2,0},{3,0},{4,0},{5,0},{6,0},{7,0},{8,0},{9,0}
        };
               
        words(line1[1],"a",letters_dict);
        words(line1[2],"m",letters_dict);
        words(line1[3],"february",letters_dict);
        words(line2[0],"from",letters_dict);
        words(line2[1],"Commander",letters_dict);
        words(line2[2],"in",letters_dict);
        words(line2[3],"chief",letters_dict);
        words(line3[0],"target",letters_dict);
        words(line4[0],"militaries",letters_dict);
        words(line6[0],"heil",letters_dict);
        words(line6[1],"wizard",letters_dict);
        words(line5[0],"dispatch",letters_dict);
        words(line5[1],"as",letters_dict);
        words(line5[2],"soon",letters_dict);
        if(line3.Count==2&&letters_dict.ContainsKey(line3[1][0])){
            switch(letters_dict[line3[1][0]]){
                case 'a':
                words(line3[1],"airport",letters_dict);
                break;
                case 'h':
                words(line3[1],"highway",letters_dict);
                break;
                 case 'b':
                words(line3[1],"byway",letters_dict);
                break;
                 case 'l':
                words(line3[1],"land",letters_dict);
                break;
            }
               
            
        }
        else if(line3.Count>2&&letters_dict.ContainsKey(line3[1][0])){
             switch(letters_dict[line3[1][0]]){
                case 'r':
                words(line3[1],"residental",letters_dict);
                words(line3[2],"area",letters_dict);
                break;
                 case 'm':
                words(line3[1],"millitary",letters_dict);
                words(line3[2],"base",letters_dict);
                break;
        }}
        
        Dictionary<string,string> militaries=new Dictionary<string, string>();
       for(int i=1;i<line4.Count;i++){
           if(line4[i][0]>='0'&&line4[i][0]<='9'){
               string nom=line4[i];
               militaries[decodeword(line4[i+1],letters_dict)]=nom;
           }

        }
        int shift_scale=int.Parse(militaries["infantries"])%10;
        fillNOMdict(shift_scale,nom_dict);
        decodenombers(militaries,nom_dict);
        MakeOutFile(file,militaries,decodeword(line3[1],letters_dict));

        

        
        


            
    }

        private static void decodenombers(Dictionary<string, string> militaries, Dictionary<int, int> nom_dict)
        {if(militaries.ContainsKey("infantries")){
            militaries["infantries"]= decodenomber(militaries["infantries"],nom_dict).ToString();
        }
          if(militaries.ContainsKey("panzers")){
           militaries["panzers"]=decodenomber(militaries["panzers"],nom_dict).ToString();
        }
          if(militaries.ContainsKey("bombers")){
          militaries["bombers"]=decodenomber(militaries["bombers"],nom_dict).ToString();
          }
        }

        private static int decodenomber(string n,Dictionary<int, int> nom_dict)
        {   int final=0;
            int m=n.Length;
           char[] temp= n.ToCharArray();
            int[] nom=new int[m];
            for(int i=0;i<m;i++){
                nom[i]=temp[i]-'0';
            }
            for(int i=0 ;i<nom.Length;i++){
                nom[i]=nom_dict[nom[i]];
            }
            for(int i=0 ;i<nom.Length;i++){
               final=final*10+nom[i];
            }
            
            return final;
        }

        private static void MakeOutFile(string file_name,Dictionary<string, string> militaries, string target)
        {string[] name =file_name.Split(@"\");
            string path="Output\\"+name[1];
            if(target=="millitary")
                target=target+" base";
            else if(target=="residental")
             target=target+" area";
        string contents="the target is :"+$"{target}\n"+"needed forces:\n";
        if(militaries.ContainsKey("infantries")){
            double n=int.Parse(militaries["infantries"])*1.1;
            n=(int)n;
            contents=contents+n.ToString()+"  infantries\n";
        }
        if(militaries.ContainsKey("bombers")){
             int n=int.Parse(militaries["bombers"])*3;
            contents=contents+n.ToString()+"  bombers\n";
        }
        if(militaries.ContainsKey("panzers")){
            int n=int.Parse(militaries["panzers"])*2;
            contents=contents+n.ToString()+"  panzers\n";
        }
            
            File.WriteAllText(path,contents);
            
        }

        private static void fillNOMdict(int shift_scale,Dictionary<int,int> dict)
        {for(int i=0;i<=9;i++){
            if(i-shift_scale>=0)
            dict[i]=(i-shift_scale)%10;
            else if(i-shift_scale<0)
              dict[i]=(i-shift_scale)+10;
        }
        }

        ////////words
        public static void words(string unknown,string known,Dictionary<char,char> dict){
        int i=0;
        for(i=0;i<unknown.Length;i++){
             dict[unknown[i]]=known[i];
        }
    }


//////
    public static string decodeword( string unknown,Dictionary<char,char> dict){
        int i=0;
        string word="";
        unknown=unknown.ToLower();
        for(i=0;i<unknown.Length;i++){
           word+=dict[unknown[i]];
        }
        return word;
        
       
    }


        static void Main(string[] args)
        {//InitLines("input\\Text17.txt");
           MakeOutputOf("input");
        }/////main
    }


}
