using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiiDemo.Service
{
    public class VisitorCount : IVisitorCount
    {
        public int Count { get; set; }
        public int GetCount()
        {
            Count++;
            return Count;
        }
    }
}
