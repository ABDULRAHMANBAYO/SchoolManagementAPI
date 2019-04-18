namespace SchoolManagementSystem.Models
{
    public class Courses
    {
        public string CourseId { get; set; }
        public string CourseName{get;set;}

    }

    public enum CourseType{
        Theory,
        Practical

    }
    public enum Status {Elective,Complusory }

    public enum CourseUnit{
    }
}