using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.ConsoleApp3
{
    public abstract class Student : IStudent
    {
      
        public string CourseName { get ; set ; }
        public IUniversity university { get ; set; }
        public string FirstName { get ; set; }
        public string LastName { get; set ; }
    }
}
