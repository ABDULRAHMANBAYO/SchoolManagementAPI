namespace SchoolManagementSystem.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public Courses Courses { get; set; }

    }
}