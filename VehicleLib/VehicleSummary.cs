using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLib
{
    public class VehicleSummary
    {
        public float BasePrice { get; set; }
        public float FactoryPackages { get; set; }
        public float Accessories { get; set; }
        public float DestinationAndHandlingFees { get; set; }
        public float MSRP { get; set; }

        

        public VehicleSummary()
        {
            FactoryPackages = Accessories = DestinationAndHandlingFees  = 0;
        }
    }
}
