using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleLib;
using System.Collections.Generic;

namespace VehicleConfigTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add( new Vehicle("Mitsubishi", "Evolution", "GSR", 2015) );
            vehicles.Add(new Vehicle("Mitsubishi", "Evolution", "MR", 2015));
            vehicles.Add(new Vehicle("Nissan", "Maxima", "S", 2015));
            vehicles.Add(new Vehicle("Nissan", "Maxima", "Platinum", 2015));
            Assert.AreEqual(vehicles.Count, 4);
        }
    }
}
