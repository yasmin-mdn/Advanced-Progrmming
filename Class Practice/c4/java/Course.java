import java.util.ArrayList;
public class Course {
    public String Name;
    public int Credits;
    public int Semester;
    public Instructor Instructor;
    public ArrayList<Student> students;
    public ArrayList<Grade> everyOnesGrade;
    

    public Course(String name,int credits,int semester,Instructor instructor ){
        this.Name=name;
        this.Credits=credits;
        this.Semester=semester;
        this.Instructor=instructor;
        this.students=new ArrayList<Student>();
        this.everyOnesGrade=new ArrayList<Grade>();
        
    }

   
 
    public  void RegisterStudent(Student st){
     st.AddCourses(this);
     students.add(st);
    }


    public void PrintStudent(){
        System.out.println("students for course  "+this.Name);
        for(Student st:this.students)
        System.out.println(st.GetInfo());

    }

    public void PrintEveryonesGrade(){
        System.out.println("Grades for course  "+this.Name);
        for(Grade g:this.everyOnesGrade)
        System.out.println(g.GetInfo());


    }

    public String GetInfo(){
        return this.Name +"->"+this.Instructor.Name ;
    }

}