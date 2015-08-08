using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleLib
{
    public class Vehicle : VehicleConfig
    {

        public Vehicle() : base()
        {

        }

        public Vehicle(string manufacturerCode, string modelCode, string styleTrim, int year) 
            : base( manufacturerCode,  modelCode,  styleTrim,  year)
        {

        }

        public Vehicle(string manufacturerCode, string modelCode, string styleTrim)
            : base(manufacturerCode, modelCode, styleTrim)
        {

        }

    }
}
