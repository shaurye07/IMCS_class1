using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First name: ");
            String F_name = Console.ReadLine();
            Console.WriteLine("Enter the Middle name: ");
            String M_name = Console.ReadLine();
            Console.WriteLine("Enter the Last name: ");
            String L_name = Console.ReadLine();

            String formal_name = NameShorter.Shortmyname(F_name, M_name, L_name);

            Console.WriteLine("Your formal name is : "+formal_name);
            Console.ReadKey();
        }
    }
}
