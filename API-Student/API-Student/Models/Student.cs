using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API_Student.Models
{
    public class Student
    {
        [Key]
        [Required]
        [Range(1,9999)]
        public int StudentID { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage ="This field is mandatory {0}")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is mandatory {0}")]
        [StringLength(30, ErrorMessage = "This field must contain between {2} and {1} characters", MinimumLength = 2)]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}",ApplyFormatInEditMode= true)]
        public DateTime EnrollmentDate { get; set; }
       

    }
}