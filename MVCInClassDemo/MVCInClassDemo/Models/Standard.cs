using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCInClassDemo.Models
{
    
    public class UnderGradLevel
    {
        public UnderGradLevel()
        {

        }
        public int UnderGradLevelId { get; set; }
        public string UnderGradLevelName { get; set; }

        public ICollection<Student> Students { get; set; }

    }

}