using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Registration
{
    internal class StudentInfoClass
    {
        public static String firstName = "";
        public static String lastName = "";
        public static String middleName = "";
        public static String address = "";
        public static String program = " ";
        public static long age = 0;
        public static long contactno = 0;
        public static long studentno = 0;

        public static String GetfirstName()
        {
            return firstName;
        }
        public static String GetlastName()
        {
            return lastName;
        }
        public static String GetmiddleName()
        {
            return middleName;
        }
        public static String Getaddress()
        {
            return address;
        }
        public static String GetProgram() {
            return program; }

        public static long Getage()
        {
            return age;
        }
       
        public static long Getcontactno()
        {
            return contactno;
        }
        public static long Getstudentno()
        {
            return studentno;
        }
        public delegate long DelegateNumber();
        public delegate string DelegateText();    


    }
}
