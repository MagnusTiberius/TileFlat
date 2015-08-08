using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleLib;
using System.Collections.Generic;

namespace VehicleConfigTest
{
    [TestClass]
    public class UnitTest1
    {
        const string sel1 = "SightAndSound";

        [TestMethod]
        public void TestMethod1()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle("Mitsubishi", "Evolution", "GSR", 2015) );
            vehicles.Add(new Vehicle("Mitsubishi", "Evolution", "MR", 2015));
            vehicles.Add(new Vehicle("Nissan", "Maxima", "S", 2015));
            vehicles.Add(new Vehicle("Nissan", "Maxima", "SV", 2015));
            vehicles.Add(new Vehicle("Nissan", "Maxima", "SL", 2015));
            vehicles.Add(new Vehicle("Nissan", "Maxima", "SR", 2015));
            vehicles.Add(new Vehicle("Nissan", "Maxima", "Platinum", 2015));

            vehicles[0].GetOptionalFactoryPackage().SelectMulti("SightAndSound", "PremiumPackage");
            vehicles[0].GetInteriorOptionsFactoryPackage().SelectOne("BlackLeather");
            vehicles[0].GetColorOptionsFactoryPackage().SelectOne("RallyRed");

            Assert.AreEqual(vehicles.Count, 7);
        }
    }
}
