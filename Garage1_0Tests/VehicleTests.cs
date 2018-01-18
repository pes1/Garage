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
        public void VehicleTest01()
        {
            Garage<Vehicle> ettFintGarage = new Garage<Vehicle>(10);
            //Assert.IsTrue(ettFintGarage is Garage<Vehicle>);
            Assert.IsTrue(
                ettFintGarage.NoOfParkingSpots == 10);

            //Assert.AreEqual(     , ettFintGarage);

            //Assert.Fail();
        }

        [TestMethod()]
        public void VehicleTest02()
        {
            Garage<Vehicle> ettFintGarage = new Garage<Vehicle>(100);
            Assert.IsTrue(
                ettFintGarage.NoOfParkingSpots >= 10);

            //Assert.AreEqual(     , ettFintGarage);

            //Assert.Fail();
        }

        [TestMethod()]
        public void VehicleTest03()
        {
            Vehicle ettFordon = new Personbil();
            Assert.IsTrue(ettFordon is Vehicle);
        }

        [TestMethod()]
        public void VehicleTest04() //- Default values.
        {
            Vehicle ettFordon = new Personbil();
            Console.WriteLine("Färgen  är: \t" + ettFordon.Color);
            Console.WriteLine("Vikten  är: \t" + ettFordon.Weight);
            Console.WriteLine("Längden är: \t" + ettFordon.Length);
            Assert.IsTrue(ettFordon.Color == "NoColor");
        }

        [TestMethod()]
        public void VehicleTest05() //- Default values.
        {
            Vehicle ettFordon = new Personbil();
            Console.WriteLine("Färgen  är: \t" + ettFordon.Color);
            Console.WriteLine("Vikten  är: \t" + ettFordon.Weight);
            Console.WriteLine("Längden är: \t" + ettFordon.Length);
            if (ettFordon.VehicleType == Vehicle.FordonsTyper.Personbil)
            {
                Console.WriteLine("Fordonet är en: {0}", ettFordon.VehicleType);
            }


            Assert.IsTrue(ettFordon.VehicleType == Vehicle.FordonsTyper.Personbil);
        }


        [TestMethod()]
        public void VehicleTest06() //- Default values.
        {
            Vehicle ettFordon = new Personbil("Röd");
            Console.WriteLine("Färgen  är: \t" + ettFordon.Color);
            Console.WriteLine("Vikten  är: \t" + ettFordon.Weight);
            Console.WriteLine("Längden är: \t" + ettFordon.Length);
            if (ettFordon.VehicleType == Vehicle.FordonsTyper.Personbil)
            {
                Console.WriteLine("Fordonet är en: {0}", ettFordon.VehicleType);
            }


            Assert.IsTrue(ettFordon.VehicleType == Vehicle.FordonsTyper.Personbil);
        }


        [TestMethod()]
        public void VehicleTest07() //- Default values.
        {
            Vehicle ettFordon = new Personbil("Röd", 1500f, 5f, "BCA321");
            Console.WriteLine("Färgen  är: \t" + ettFordon.Color.ToLower());
            Console.WriteLine("Vikten  är: \t{0} \t kg", ettFordon.Weight);
            Console.WriteLine("Längden är: \t{0} \t m", ettFordon.Length);
            if (ettFordon.VehicleType == Vehicle.FordonsTyper.Personbil)
            {
                Console.WriteLine("Fordonet är en: {0}", ettFordon.VehicleType);
            }


            Assert.IsTrue(ettFordon.VehicleType == Vehicle.FordonsTyper.Personbil);
        }

        [TestMethod()]
        public void VehicleTest08_SkapaBåt_OKresultat() //- Default values.
        {
            // Arrange
            Vehicle ettFordon = new Båt("Grön", 3000f, 7.30f, "VAT69");

            // Act
            Console.WriteLine("Färgen  är: \t" + ettFordon.Color.ToLower());
            Console.WriteLine("Vikten  är: \t{0} \t kg", ettFordon.Weight);
            Console.WriteLine("Längden är: \t{0} \t m", ettFordon.Length);
            if (ettFordon.VehicleType == Vehicle.FordonsTyper.Båt)
            {
                Console.WriteLine("Fordonet är en: {0}", ettFordon.VehicleType);
            }

            // Assert
            Assert.IsTrue(ettFordon.VehicleType == Vehicle.FordonsTyper.Båt);
        }

        [TestMethod()]
        public void VTest09_SkapaMC_OKresultat() //- Default values.
        {
            // Arrange
            Vehicle ettFordon = new Motorcykel("Grön", 3000f, 7.30f, "DOT609");

            // Act
            Console.WriteLine("Färgen  är: \t" + ettFordon.Color.ToLower());
            Console.WriteLine("Vikten  är: \t{0} \t kg", ettFordon.Weight);
            Console.WriteLine("Längden är: \t{0} \t m", ettFordon.Length);
            if (ettFordon.VehicleType == Vehicle.FordonsTyper.Motorcykel)
            {
                Console.WriteLine("Fordonet är en: {0}", ettFordon.VehicleType);
            }

            // Assert
            Assert.IsTrue(ettFordon.VehicleType == Vehicle.FordonsTyper.Motorcykel);
        }





        [TestMethod()]
        public void VTest10_SkapaBUSS_OKresultat() //- Default values.
        {
            // Arrange
            Vehicle ettFordon = new Buss("Blå", 15000f, 20f, "SLL007");

            // Act
            Console.WriteLine("Färgen  är: \t" + ettFordon.Color.ToLower());
            Console.WriteLine("Vikten  är: \t{0} \t kg", ettFordon.Weight);
            Console.WriteLine("Längden är: \t{0} \t m", ettFordon.Length);
            if (ettFordon.VehicleType == Vehicle.FordonsTyper.Buss)
            {
                Console.WriteLine("Fordonet är en: {0}", ettFordon.VehicleType);
            }

            // Assert
            Assert.IsTrue(ettFordon.VehicleType == Vehicle.FordonsTyper.Buss);
        }

        [TestMethod()]
        public void VTest11_SkapaFlygplan_OKresultat() //- Default values.
        {
            // Arrange
            Vehicle ettFordon = new Flygplan("Lila", 40000f, 40f, "SE444");

            // Act
            Console.WriteLine("Färgen  är: \t" + ettFordon.Color.ToLower());
            Console.WriteLine("Vikten  är: \t{0} \t kg", ettFordon.Weight);
            Console.WriteLine("Längden är: \t{0} \t m", ettFordon.Length);
            if (ettFordon.VehicleType == Vehicle.FordonsTyper.Flygplan)
            {
                Console.WriteLine("Fordonet är en: {0}", ettFordon.VehicleType);
            }

            // Assert
            Assert.IsTrue(ettFordon.VehicleType == Vehicle.FordonsTyper.Flygplan);
        }


        [TestMethod()]
        public void VTGarageTest12_SkapaGarage_OKresultat() //- Default values.
        {
            // Arrange
            int noOfP_Spots      = 11;
            var GaragetElefanten = new Garage<Vehicle>(noOfP_Spots);

            // Act
            Console.WriteLine("Garaget heter: \t{0} ",           GaragetElefanten.Name);
            Console.WriteLine("Garaget har:   \t{0} \t platser", GaragetElefanten.NoOfParkingSpots);


            // Assert
            Assert.IsTrue(GaragetElefanten.NoOfParkingSpots == noOfP_Spots);
        }

        [TestMethod()]
        public void VTGarageTest13_SkapaGarage_2ParametrarOKresultat() //- Default values.
        {
            // Arrange
            int noOfP_Spots = 11;
            var GaragetElefanten = new Garage<Vehicle>("Elefanten", noOfP_Spots);

            // Act
            Console.WriteLine("Garaget heter: \t{0} ",           GaragetElefanten.Name);
            Console.WriteLine("Garaget har:   \t{0} \t platser", GaragetElefanten.NoOfParkingSpots);


            // Assert
            Assert.IsTrue(GaragetElefanten.NoOfParkingSpots == noOfP_Spots);
        }


        [TestMethod()]
        public void VTGarageTest14_SkapaGarage_med_fordon_OKresultat() //- Default values.
        {
            // Arrange
            int noOfP_Spots = 11;
            var GaragetElefanten = new Garage<Vehicle>("Elefanten", noOfP_Spots);

            // Act
            Console.WriteLine("Garaget heter: \t{0} ", GaragetElefanten.Name);
            Console.WriteLine("Garaget har:   \t{0} \t platser", GaragetElefanten.NoOfParkingSpots);


            // Assert
            Assert.IsTrue(GaragetElefanten.NoOfParkingSpots == noOfP_Spots);
        }




    } //- of class VehicleTests






}