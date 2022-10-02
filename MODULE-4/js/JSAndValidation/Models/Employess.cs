using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JSAndValidation.Models
{
    public class Employess
    {
        [Required(ErrorMessage ="The First Name Is Required")]
        public string F_Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Password { get; set; }
        [Required(ErrorMessage = "The Conform Password Is Required")]
        public string CnfPassword { get; set; }
    }
}
