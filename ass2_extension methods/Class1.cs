using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class NameShorter
    {
        public static string Shortmyname(this String n1,  String n2, String n3)
        {
            StringBuilder s1 = new StringBuilder();

            if (n1.Length>0)
            {
                char[] chararr1 = n1.ToCharArray();
                if (chararr1.Length > 5)
                {
                    chararr1[0] = char.ToUpper(chararr1[0]);
                    s1.Append(chararr1[0] + ".");
                }

                char[] chararr2 = n2.ToCharArray();
                if (chararr2.Length > 2)
                {
                    chararr2[0] = char.ToUpper(chararr2[0]);
                    s1.Append(chararr2[0] + ".");
                }

                s1.Append(n3);
            }

            return s1.ToString();
        }
    }
}
