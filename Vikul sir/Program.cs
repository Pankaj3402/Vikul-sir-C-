using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vikul_sir
{
    internal class Program
    {
        static void Main(string[] args)

        //// integral types


        {
            byte v1 = 10;

            Console.WriteLine(v1);
            Console.WriteLine($"byte min value:{byte.MinValue}max value:{byte.MaxValue}" + $"size:{sizeof(byte)}bytes");

            short v2 = 10;
            Console.WriteLine(v2);
            Console.WriteLine($"short min value:{short.MinValue}max value:{short.MaxValue}" + $"size:{sizeof(short)}bytes");


            int v3 = 1000;
            Console.WriteLine(v3);
            Console.WriteLine($"int min value:{int.MinValue}max value:{int.MaxValue}" + $"size:{sizeof(int)}bytes");



            long v4 = 77092944;
            Console.WriteLine(v4);
            Console.WriteLine($"long min value:{long.MinValue}max value:{long.MaxValue}" + $"size:{sizeof(long)}bytes");




            //// floating types


            float v5 = 10.5f;
            Console.WriteLine($"float:val:{v5}min value:{float.MinValue}max value:{float.MaxValue}" + $"size:{sizeof(float)}bytes");


            double v6 = 10.5555;
            Console.WriteLine($"double:val:{v6}min value:{double.MinValue}max value:{double.MaxValue}" + $"size:{sizeof(double)}bytes");


            decimal v7 = 102152.15m;
            Console.WriteLine($"decimal:val:{v7}min value:{decimal.MinValue}max value:{decimal.MaxValue}" + $"size:{sizeof(decimal)}bytes");



            //// boolen type


            bool status = true;
            Console.WriteLine($"bool:value:{status} size:{sizeof(bool)}bytes");


            //// string types


            char currency = '$';
            Console.WriteLine($"char:value:{currency} size:{sizeof(char)}bytes");


            string name = "Vikul sir";
            Console.WriteLine($"string:value:{name}");


            //// string function


            name = "Anil";
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());

            name = "    anil";
            Console.WriteLine(name.Trim());

            name = "\"pankaj\"";
            Console.WriteLine(name);

            string FirstName = "pankaj";
            string LastName = "more";
            string fullname = FirstName + " " + LastName;
            Console.WriteLine(fullname);

            fullname = FirstName + "\t " + LastName;
            Console.WriteLine(fullname);

            string middlename = "machindra";
            fullname = string.Concat(FirstName, " ", middlename, " ", LastName);
            Console.WriteLine(fullname);


            // placeholder syntax


            fullname = string.Format("fullname:{0} {1} {2}", FirstName, middlename, LastName);
            Console.WriteLine(fullname);

            fullname = $"full name : {FirstName} {middlename} {LastName}";
            Console.WriteLine(fullname);

            string email = "pankaj342002@gmail.com";
            int index = email.IndexOf('@');
            Console.WriteLine($"index of @:{index}");

            string username = email.Substring(0, index);
            Console.WriteLine($"username:{username}");

            string domain = email.Substring(index + 1, email.Length - index - 1);
            Console.WriteLine($"domain:{domain}");
        }


          
    }
}
