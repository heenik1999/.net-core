using _1.DBContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Di.services
{
    public interface IViCount
    {
        List<Stud> getData();
    }
}
