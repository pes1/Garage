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
    public class GarageTests
    {
         [TestMethod()]
        public void GarageTest001_OKresultat() //- Default values.
        {
            // Arrange
            var ettNyttGarage = new Garage<Vehicle>(10);

            // Act
            Console.WriteLine("Garage skapat med {0} platser\t", ettNyttGarage.ParkingSpots);
            //Console.WriteLine("Vikten  är: \t{0} \t kg", ettFordon.Weight);
            //Console.WriteLine("Längden är: \t{0} \t m", ettFordon.Length);
            //if (ettFordon.VehicleType == Vehicle.FordonsTyper.Flygplan)
            //{
            //    Console.WriteLine("Fordonet är en: {0}", ettFordon.VehicleType);
            //}
            Console.WriteLine(" Objekttypen är: " + ettNyttGarage.GetType());
            // Assert
            //Assert.IsTrue( ettNyttGarage.GetType.toString() );
        }









    }
}