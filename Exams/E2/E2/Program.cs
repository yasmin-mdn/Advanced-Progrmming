using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length!=2){
                Usage();
                return;
            }
            string cmd=args[0];
            string todo_name=args[1];
            if(cmd=="new"){
                Todo.creatNew(todo_name);
            }
            else if(cmd=="add"){
                Todo t=Todo.GetTodo(todo_name);
                t.AddFromConsole();
                t.Save();
            
            }
            else if(cmd=="list"){
                Todo t=Todo.GetTodo(todo_name);
                t.PrintItems();
            }
        }

        private static void Usage()
        {
            Console.WriteLine("list|add|new <to do list>");
        }
    }
}
