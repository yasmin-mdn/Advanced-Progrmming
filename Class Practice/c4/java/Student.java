import java.util.ArrayList;
public class  Student {
    public String Name;
    public int Id;
    public ArrayList<Course>Courses;
    public ArrayList<Grade>Grades;
    public Student(String name,int id){
    this.Name=name;
    this.Id=id;
    this.Courses=new ArrayList<Course>();
    this.Grades=new ArrayList<Grade>();
}

public String GetInfo()
{
return this.Name +" "+this.Id ;
}

public void AddCourses(Course c){
    Courses.add(c);
}

public void AddGrades(Grade g){

    Grades.add(g);
}

public  void  PrintGrades() {
    System.out.println("Grades for "+this.Name);
    for(Grade g: this.Grades)
        System.out.println(g.GetInfo()); 
    
}



public  void  PrintCourses() {
    System.out.println("course for "+this.Name);
    for(Course c: this.Courses)
   System.out.println(c.GetInfo()); 
    
}
}