using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.ConsoleApp1
{
    class origin
    {
        static void Main(string[] args)
        {
            UniversityEntities db = new UniversityEntities();

            var sList = new List<StudentTable>();
            var isNewEntery = false;

            do
            {
                StudentTable s1 = new StudentTable();

                Console.Write("Enter the Student's FirstName : ");
                s1.FirstName = Console.ReadLine();

                Console.Write("Enter the Student's LastName : ");
                s1.LastName = Console.ReadLine();

                s1.FullName = string.Concat(s1.FirstName + " " + s1.LastName);

                Console.Write("Enter the SUBJECT1 mark : ");
                s1.Subject1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the SUBJECT2 mark : ");
                s1.Subject2 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the SUBJECT3 mark : ");
                s1.Subject3 = Convert.ToDecimal(Console.ReadLine());

                s1.Total = (s1.Subject1 + s1.Subject2 + s1.Subject3);

                s1.Per = (s1.Total) / 3;

                if (s1.Per < 33)
                {
                    s1.Res = "FAIL";
                }
                else
                {
                    s1.Res = "PASS";
                }

                sList.Add(s1);
                db.StudentTables.Add(s1);

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

                Console.WriteLine(String.Format("{0} \t {1} \t{2} \t Subject1 : {3} \t Subject2 : {4} \t Subject3 : {5} \t Total : {6} \t Percentage {7} \t Result {8}",
                    item.FirstName, item.LastName, item.FullName, item.Subject1,
                 item.Subject2, item.Subject3, item.Total, item.Per, item.Res));
            }

             Console.WriteLine("The Details of Students whose name starts with 'S' ");

            var sl= db.StudentTables
                .Where(x => x.FirstName.ToUpper().StartsWith("S")).ToList();

           foreach (var item in sl)

            {
                Console.WriteLine(item.FirstName + "\t " + item.LastName +
                    "\t" + item.FullName + "\t" + item.Subject1 + "\t" + item.Subject2 +
                "\t" + item.Subject3 + "\t" + item.Total + "\t" + item.Per + "\t" + item.Res);

            }
           

            Console.ReadLine();
        }
    }
}
