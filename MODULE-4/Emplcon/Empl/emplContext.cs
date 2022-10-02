using System;

namespace Empl
{
    internal class emplContext
    {
        public string EmployeeId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public long? Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? Doj { get; set; }
        public string Password { get; set; }
    }
}