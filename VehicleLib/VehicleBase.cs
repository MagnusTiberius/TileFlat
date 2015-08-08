using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLib
{
    public abstract class VehicleBase
    {
        protected Manufacturer manufacturer = null;
        protected Model model = null;
        protected StyleTrim styleTrim = null;
        protected List<Color> ColorList = new List<Color>();
        protected List<Package> standardPackages = null;
        protected List<Package> standardExteriorOptionalPackages = null;
        protected List<Package> standardInteriorOptionalPackages = null;
        protected List<Package> optionalFactoryPackages = null;
        protected List<Package> optionalAccessoryPackages = null;
        protected float BasePrice;
        protected float TotalPackagePrice;
        protected float NetPrice;
        protected string[] FeatureList;


        protected ManufacturerList ml = null;
        protected ModelList modelList = null;
        public string ManufacturerCode { get; set; }
        public string ModelCode { get; set; }
        public string StyleTrim { get; set; }
        public int Year { get; set; }
        
        public VehicleBase()
        {


        }

        public VehicleBase(string manufacturerCode, string modelCode, string styleTrim, int year)
        {
            ManufacturerCode = manufacturerCode;
            ModelCode = modelCode;
            StyleTrim = styleTrim;
            Year = year;
        }

        public VehicleBase(string manufacturerCode, string modelCode, string styleTrim)
        {
            ManufacturerCode = manufacturerCode;
            ModelCode = modelCode;
            StyleTrim = styleTrim;
            Year = DateTime.Today.Year;
        }



    }
}
