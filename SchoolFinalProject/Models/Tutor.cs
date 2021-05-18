using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolFinalProject.Models
{
    public class Tutor
    {
        [Key]
        //Tutor Id
        public int Id { get; set; }
        //Tutor Name
        public string Tutor_Name { get; set; }
        //Tutor Address
        public string Tutor_Address { get; set; }
        //Tutor Contact
        public string Tutor_Contact { get; set; }
    }
}
