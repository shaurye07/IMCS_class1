using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Driver
    {
        private IVehicle vehicleToDrive;

        public Driver(IVehicle vehicleToDrive)
        {
            this.vehicleToDrive = vehicleToDrive;
        }

        public bool EvasiveManeuvers(bool alertOffendingDriver)
        {
            bool success = false;
            if (alertOffendingDriver)
                success = this.vehicleToDrive.ApplyBrakes() && this.vehicleToDrive.HonkHorn();
            else
                success = this.vehicleToDrive.ApplyBrakes();

            return success;
        }
    }
}
