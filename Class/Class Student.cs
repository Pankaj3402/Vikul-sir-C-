//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Class
//{
//     class Student
//    {
//        public string firstname;
//        public string lastname;


//        public void start(string fn, string ln)
//        {
//            firstname = fn;
//            lastname = ln;
//        }

//        public void print()
//        {
//            Console.WriteLine($"first name : {firstname} lastname : {lastname}");
//        }
//    }
//}


public class student
{
    public string firstname;
    public string lastname;

    public void names(string fn , string ln)
    {
        firstname = fn;
        lastname = ln;
    }

    public void print()
    {
        Console.WriteLine($"fullname : {firstname} {lastname}");
    }

}