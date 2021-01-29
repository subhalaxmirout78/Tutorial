using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.ClassLib1;

namespace Tutorial.ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityEntities db = new UniversityEntities();
            var sList = new List<StudentTable>();

            var studentlist = db.StudentTables.Add(sList);

            foreach (var item in studentlist)
            {

                Console.WriteLine(String.Format("{0} \t {1} \t{2} \t {3} \t  {4} \t {5} \t {6} \t {7} \t {8}",
                    item.FirstName, item.LastName, item.FullName, item.Subject1,
                 item.Subject2, item.Subject3, item.Total, item.Per, item.Res));
            }
            Console.ReadLine();
        }
    }
}
