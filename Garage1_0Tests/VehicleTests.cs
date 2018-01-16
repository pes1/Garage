using Microsoft.VisualStudio.TestTools.UnitTesting;
using Garage1_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1_0.Tests
{
    [TestClass()]
    public class VehicleTests
    {
        [TestMethod()]
        public void VehicleTest()
        {
            Garage<Vehicle> ettFintGarage = new Garage<Vehicle>(new Vehicle());
            Assert.IsTrue(ettFintGarage is Garage<Vehicle>);

            //Assert.AreEqual(     , ettFintGarage);

            //Assert.Fail();
        }

        [TestMethod()]
        public void VehicleTest2()
        {
            Garage<Vehicle> ettFintGarage = new Garage<Vehicle>(new Personbil());
            Assert.IsTrue(ettFintGarage is Garage<Vehicle>);

            //Assert.AreEqual(     , ettFintGarage);

            //Assert.Fail();
        }
    }
}