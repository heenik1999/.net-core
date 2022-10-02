using _1.DBContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Di.services
{
    public class ViCount : IViCount
    {
        private StudentContext _context;
        public ViCount(StudentContext context)
        {
            _context = context;
        }
        public List<Stud> getData()
        {
            List<Stud> students = _context.Studs.ToList();

            return students;
        }

    }
}
