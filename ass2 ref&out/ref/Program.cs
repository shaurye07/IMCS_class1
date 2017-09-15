using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
             int a_number = 20;
            Console.WriteLine("before manipulation: {0}", a_number);
            manipulatedata(ref a_number);
            Console.WriteLine("after manipulation: {0}", a_number);
            Console.ReadKey();

        }

        public static int manipulatedata(ref int incomingnumber)
        {
            incomingnumber = incomingnumber + 10;
            return incomingnumber;

        }
        
    }
}
