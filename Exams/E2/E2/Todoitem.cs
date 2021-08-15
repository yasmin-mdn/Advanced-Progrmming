using System;

public class Todoitem{
    public string Name;
    public int Priority;
    public DateTime Date;
    public Todoitem(string name,int priority,DateTime date){
        this.Name=name;
        this.Date=date;
        this.Priority=priority;
    }
    public static Todoitem Parse(string line){
      string[] token= line.Split(",");
      string name=token[0];
      int priority=int.Parse(token[1]);
      DateTime date=DateTime.Parse(token[2]);
       Todoitem t=new Todoitem(name,priority,date);
       return t;
    }

    public string Serialize(){
        string st=this.Name +","+ this.Priority.ToString()+","+this.Date.ToString();
        return st;
    }
    public static Todoitem ReadFromConsole(){
        string line;
        line= Console.ReadLine();
        return Parse(line);
    }
}