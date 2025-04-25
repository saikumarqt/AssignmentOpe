using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOpe
{
    internal class Program
    {
        /*
         * Assignment Operator is used assign the values
         */
        static void Main(string[] args)
        {
            int a = 100;
            int b = a;
            Console.WriteLine(a);
            Console.WriteLine("value of b is"+b);
            //a = a + 100;
            a += 100;
            Console.WriteLine("after adding"+a);
            a-=100;
            Console.WriteLine("after subtracting"+ a);
            a *= 100;
            Console.WriteLine("after multiplication" + a);
            a /= 100;
            Console.WriteLine("after division" + a);
            a %= 100;
            Console.WriteLine("after modulus" + a);


        }
    }
}
