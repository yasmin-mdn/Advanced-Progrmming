using System;
using System.Globalization ;
using System.IO;



namespace cs
{
    class Program
    {
        const String path="phoneBook.txt";

        static void Main(string[] args)
        {   
            if(args.Length!=1&&args.Length!=2){
                Usage();
                return;
                }

            if(args[0]=="add"){
                AddNewPerson();
            }
            else if(args[0]=="list"){
                ListPeople();
            }
            else if(args[0]=="find")
            {   //FindPerson(args);
                if(!FindPerson(args))
                Usage();
            }
               else
                Usage();
                 

               
        }

        private static bool FindPerson(string[] args)
        {
            if(args.Length!=2){
                return false;
            }
            string searchKey=args[1].ToLower();
            string[] line =File.ReadAllLines(path);
            bool wasFound=false;
            foreach(string l in line){
                string[] seprate = l.ToLower().Split(',');
                string name=seprate[0];
                string nomber=seprate[1];
                if(searchKey==name){
                    Console.WriteLine(l);
                    wasFound=true;
                }
            }
            if(!wasFound)
            Console.WriteLine("NOT FOUND");
            return true;
        }

        private static void ListPeople()
        {
            string Info=File.ReadAllText(path);
            Console.WriteLine(Info);
        }

        private static void AddNewPerson()
        {
           Console.WriteLine("name?");
           String name=Console.ReadLine();
           File.AppendAllText(path,name+",");
            Console.WriteLine("nomber?");
           String phoneNomber=Console.ReadLine();
           File.AppendAllText(path,phoneNomber);
            
        }

        private static void Usage()
        {
            Console.WriteLine("phone book");
            Console.WriteLine("to use phone book enter add,find,list commands");
        }
    }
}
