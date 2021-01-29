using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.ConsoleApp3
{
    public class Teacher : IPerson
    {
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }

        public string Dept { get; set; }
    }
}
