 public class Main{

    public static void main(String[] args) {
       Instructor maleki = new Instructor("maleki",123,"phd"); 
       Course ap=new Course("ap",3,98992,maleki);
        
       Instructor hakami = new Instructor("hakami",345,"phd"); 
       Course dm=new Course("dm",3,98992,hakami);

       Student ali= new Student("ali",98521111);
       Student zahra= new Student("zahra",98521111);

       Grade aliGrade =new Grade(98992,ap,(float)17.5);
       Grade zahrGrade=new Grade(9899,dm,(float)16.25);
       Grade zahrGrade2=new Grade(9899,ap,(float)15.25);

       ap.RegisterStudent(ali);
       ap.RegisterStudent(zahra);
       dm.RegisterStudent(ali);
       dm.RegisterStudent(zahra);

       ap.PrintStudent();
       dm.PrintStudent();

       ali.PrintCourses();
       zahra.PrintCourses();

       
       ali.PrintGrades();
       zahra.PrintGrades();
      

      aliGrade.addingGradesForStudent(ali,ap);
      zahrGrade.addingGradesForStudent(zahra,dm);
      zahrGrade2.addingGradesForStudent(zahra,ap);

      ap.PrintEveryonesGrade();

      dm.PrintEveryonesGrade();

      ali.PrintGrades();
      zahra.PrintGrades();

    }


 }