public class Grade{
    public float Value;
    public Course Course;
    public int Semester;
   

    public Grade(int semester,Course course,float value ){
        this.Value=value;
        this.Semester=semester;
        this.Course=course;
        
    }
  
    public  void addingGradesForStudent(Student st,Course c){
        st.AddGrades(this);
        c.everyOnesGrade.add(this);
       }

    
    
    public String GetInfo(){
        return "course: "+ Course.Name + " semester: "+Integer.toString(this.Semester)+"grade :"+ Float.toString(this.Value);}

 }

