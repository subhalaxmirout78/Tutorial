using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.ConsoleApp3
{
    public class MCAStudent : Student
    {
        public MCAStudent()
        {
            CourseName = "MCA";
            university = new University()
            {
                Name = "OUAT",
                Address="BBSR"
            };
        }
    }
}
