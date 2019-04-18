using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public class Students
    {
        public string MatricNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string StateOfOrigin { get; set; }
        public string LocalGovernment { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BloodGroup { get; set; }
        public string Genotype { get; set; }
        public string Address { get; set; }
        public string Level { get; set; }
        public Gender Gender{get;set;}
        public virtual ICollection<College> College { get; set; }
        public virtual ICollection<Department> Department { get; set; }
        public virtual ICollection<Courses> Courses { get; set; }
         public virtual ICollection<NextofKin> NextofKin{get;set;}
          public virtual ICollection<Lecturers> Lecturers{get;set;}










    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum Religion
    {
        Islam,
        Christianity,

        Others
    }
    public enum MaritalStatus
    {
        Single,
        Married,

        Divorced
    }


}
