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
        //protected List<Color> ColorList = new List<Color>();
        protected List<Package> standardPackages = null;
        protected List<Package> standardExteriorOptionalPackages = null;
        //protected List<Package> standardInteriorOptionalPackages = null;
        protected List<Package> optionalFactoryPackages = null;
        protected List<Package> optionalAccessoryPackages = null;
        protected float BasePrice;
        protected float TotalPackagePrice;
        protected float NetPrice;
        protected float DestinationAndHandling;

        protected string[] FeatureList;

        protected ColorSet colorSet = null;
        protected PackageSet interiorSet = null;
        protected FeatureSet factoryFeatureSet = null;
        protected PackageSet optionalFactoryPackage = null;
        protected PackageSet optionalFactoryTransmissionPackage = null;
        protected PackageSet optionalAccessories = null;
        protected FeatureSet warranty = null;

        protected ManufacturerList ml = null;
        protected ModelList modelList = null;

        public string ManufacturerCode { get; set; }
        public string ModelCode { get; set; }
        public string StyleTrim { get; set; }
        public int Year { get; set; }
        
        

        public VehicleBase()
        {
            Init();
        }

        public VehicleBase(string manufacturerCode, string modelCode, string styleTrim, int year)
        {
            ManufacturerCode = manufacturerCode;
            ModelCode = modelCode;
            StyleTrim = styleTrim;
            Year = year;
            Init();
        }

        public VehicleBase(string manufacturerCode, string modelCode, string styleTrim)
        {
            ManufacturerCode = manufacturerCode;
            ModelCode = modelCode;
            StyleTrim = styleTrim;
            Year = DateTime.Today.Year;
            Init();
        }

        private void Init()
        {
            standardPackages = new List<Package>();
            standardExteriorOptionalPackages = new List<Package>();
            //standardInteriorOptionalPackages = new List<Package>();
            optionalFactoryPackages = new List<Package>();
            optionalAccessoryPackages = new List<Package>();

            colorSet = new ColorSet();
            factoryFeatureSet = new FeatureSet();
            interiorSet = new PackageSet();
            optionalFactoryPackage = new PackageSet();
            optionalAccessories = new PackageSet();
            warranty = new FeatureSet();
            optionalFactoryTransmissionPackage =  new PackageSet();
        }

    }
}
