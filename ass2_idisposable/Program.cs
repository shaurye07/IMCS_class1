using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Integerwrapper
    {
        public int intwrapper;

    }

    class Program:IDisposable
    {
        private List<String> _theList = new List<String>();
        

        static void Main(string[] args)
        {
                    
         

        }

        public void Dispose()
        {
            
             _theList = null;
            
        }
    }
    
}
