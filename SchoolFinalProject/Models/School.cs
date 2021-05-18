using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolFinalProject.Models
{
    public class School
    {
        [Key]
        //School  Id
        public int Id { get; set; }
        //School Name
        public string School_Name { get; set; }
        //School Branch
        public string School_Branch { get; set; }
       
    }
}
