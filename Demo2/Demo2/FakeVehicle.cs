using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class FakeVehicle :IVehicle
    {
        public int CalledHonkHorn = 0;
        public int CalledApplyBrakes = 0;

        public bool HonkHorn()
        {
            this.CalledHonkHorn++;
            return true;
        }

        public bool ApplyBrakes()
        {
            this.CalledApplyBrakes++;
            return true;
        }
    }
}
