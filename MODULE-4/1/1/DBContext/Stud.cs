using System;
using System.Collections.Generic;

#nullable disable

namespace _1.DBContext
{
    public partial class Stud
    {
        public int StudId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public long? MobileNumber { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public string StateId { get; set; }
        public string CityId { get; set; }
        public bool IsDelete { get; set; }
    }
}
