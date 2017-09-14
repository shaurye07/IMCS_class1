using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromone = Singleton.Getinstance;
            fromone.print_details("First instance");

           Singleton fromtwo = Singleton.Getinstance;
            fromtwo.print_details("Second Instance");
        }
    }
}
