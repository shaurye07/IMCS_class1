using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCInClassDemo.Models;



namespace MVCInClassDemo.DAL
{

    public class UniversityDBInitializer : DropCreateDatabaseIfModelChanges<EFDemoDBContext>
    {
        protected override void Seed(EFDemoDBContext context)
        {
            // Container

            IList<UnderGradLevel> defaultStandards = new List<UnderGradLevel>();


            defaultStandards.Add(new UnderGradLevel() { UnderGradLevelId = 1, UnderGradLevelName = "Freshmen" });
            defaultStandards.Add(new UnderGradLevel() { UnderGradLevelId = 2, UnderGradLevelName = "Sophomore" });
            defaultStandards.Add(new UnderGradLevel() { UnderGradLevelId = 3, UnderGradLevelName = "Junior" });
            defaultStandards.Add(new UnderGradLevel() { UnderGradLevelId = 4, UnderGradLevelName = "Senior" });

            foreach (UnderGradLevel ugl in defaultStandards)
                context.UnderGradLevels.Add(ugl);
            base.Seed(context);
        }


    }
}
