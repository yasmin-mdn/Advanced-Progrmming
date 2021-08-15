using System;
using System.Collections.Generic;
using System.IO;

namespace E2
{
    public class Todo
    {  private string Name;
        public string filename;
        private List<Todoitem> Items=new List<Todoitem>();

         public string FileName(string todo_name){
        
             return $"{todo_name}.csv";
         }
        
         public Todo(string name){
             this.Name=name;
             filename=FileName(name);
         }

        public static void creatNew(string name)
        {
            File.WriteAllText($"{name}.csv",string.Empty);
        }

        public void Add(Todoitem item){
            Items.Add(item);
        }
         public void PrintItems()
        {
            foreach(var v in Items ){
                Console.WriteLine(v.Serialize());
                
            }
        }

        public static Todo GetTodo(string todo_name)
        {Todo result=new Todo(todo_name);
           string[] lines= File.ReadAllLines(result.FileName(todo_name));
           foreach(var v in lines){
               Todoitem todoitem=Todoitem.Parse(v);
               result.Add(todoitem);
           }
            return result;
        }

        public void AddFromConsole()
        {string line=Console.ReadLine();
            Todoitem t=Todoitem.Parse(line);
            Items.Add(t);
            
        }

        public  void Save()
      {List<string> output=new List<string>();
        foreach(var item in Items)
        {
            output.Add(item.Serialize());

        }
        File.WriteAllLines(filename,output);
      }  
    }
}