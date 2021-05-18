using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolFinalProject.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        //Name of the Student
        public string Student_Name { get; set; }
        //Address of the student
        public string Student_Address { get; set; }
        //Contact number of the student
        public string Student_Contact { get; set; }
        //Foreign Key
        //public int SchoolID { get; set; }
        //public School School_obj { get; set; }
        //Foreign Key
        public int TutorID { get; set; }
        public Tutor Tutor_ID { get; set; }
    }
}
