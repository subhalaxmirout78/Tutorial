using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.ConsoleApp3
{
    public interface IStudent : IPerson
    {
        string CourseName { get; set; }
        IUniversity university { get; set; }
    }
}
