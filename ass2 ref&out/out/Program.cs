using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int outgoing_number = 85;
            Console.WriteLine("before mani: " + outgoing_number);
            manipulate_data(out outgoing_number);
            Console.WriteLine("after mani: " + outgoing_number);
            Console.ReadKey();
        }
        public static int manipulate_data(out int incoming_number)
        {
            incoming_number =+ 97;
            Console.WriteLine("in mani: " + incoming_number);
            return incoming_number;
        }
    }
}
