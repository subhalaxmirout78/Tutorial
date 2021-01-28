using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.ClassLib1
{

    public class StudLib
    {
       
        public int RollNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return (FirstName + LastName);
            }
        }
        public decimal Subject1 { get; set; }
        public decimal Subject2 { get; set; }
        public decimal Subject3 { get; set; }
        public decimal Total
        {
            get
            {
                return (Subject1 + Subject2 + Subject3);
            }
        }
        public decimal Per
        {
            get
            {
                return (Total / 3);
            }
        }
        public string Res
        {
            get
            {
                if (Per > 33)
                {
                    return ("Pass");
                }
                else
                {
                    return ("Fail");
                }
            }
        }
    }
}