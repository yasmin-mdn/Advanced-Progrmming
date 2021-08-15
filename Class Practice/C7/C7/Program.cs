using System;
using System.Collections.Generic;
using System.IO;

namespace C7
{
    class Program
    {
        static void Main(string[] args)
        {   string path="children-per-woman-UN.csv";
            Dictionary<Data,double> dict=new Dictionary<Data, double>();
            LoadData(path,dict);
            string country;
            int year;

            while(true){
                Console.WriteLine("country???");
                country=Console.ReadLine();
                Console.WriteLine("year???");
                year=int.Parse(Console.ReadLine());
                while(!(year>=1950&&year<=2015)){
                    Console.WriteLine("file does not contain data for year you are looking for another year???");
                    year=int.Parse(Console.ReadLine());
                }
                

                Quary(country,year,dict);
            }
        }

        private static string MakeStatment(string country, int year)
        {
            return country+year.ToString().ToLower();
        }

        private static void Quary(string country,int year,Dictionary<Data,double> dict)
        {string statment=MakeStatment(country,year);
            Data data=new Data(country,year);
            if(data.Equals(statment))
                Console.WriteLine(data.ToString()+$"  {dict[data]}");
        }

        private static void LoadData(string path,Dictionary<Data,double> dict)
        {
           string[] lines=File.ReadAllLines(path);
           foreach(var line in lines ){
               string[] tokens=line.Split(',');
               Data data=new Data(tokens[0].ToLower(),int.Parse(tokens[2]));
               dict[data]=double.Parse(tokens[3]);
           }
        }
    }
}
