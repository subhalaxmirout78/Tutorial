using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.ClassLib1;

namespace Tutorial.ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityEntities db = new UniversityEntities();


            var sList = new List<StudentTable>();

            var isNewEntery = false;

            do
            {
                var s2 = new StudentTable();

                Console.Write("Enter the Student's FirstName : ");
                s2.FirstName = Console.ReadLine();

                Console.Write("Enter the Student's LastName : ");
                s2.LastName = Console.ReadLine();

                Console.Write("Enter the SUBJECT1 mark : ");
                s2.Subject1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the SUBJECT2 mark : ");
                s2.Subject2 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the SUBJECT3 mark : ");
                s2.Subject3 = Convert.ToDecimal(Console.ReadLine());

                sList.Add(s2);

                db.StudentTables.Add(s2);

                Console.Write("Do you want to add more student data? Y or N ");

                var ans = Console.ReadLine().ToUpper();

                if (ans == "Y")
                    isNewEntery = true;
                else
                    isNewEntery = false;
            }
            while (isNewEntery == true);

            db.SaveChanges();

            var studentlist = db.StudentTables.ToList();

            foreach (var item in studentlist)

            {
                Console.WriteLine(item.FirstName + "\t " + item.LastName +
                    "\t" + item.FullName + "\t" + item.Subject1 + "\t" + item.Subject2 +
                "\t" + item.Subject3 + "\t" + item.Total + "\t" + item.Per + "\t" + item.Res);

            }
        }
    }
}