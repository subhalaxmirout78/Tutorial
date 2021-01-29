using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            MCAStudent s = new MCAStudent();
            Console.WriteLine(" University Name : " + s.university.Name);
            Console.WriteLine(" University Address : " + s.university.Address);

            Console.ReadLine();
        }   
    }
}
