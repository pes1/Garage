using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1_0
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~                        ~~~~");
            Console.WriteLine("~~~~     Garage XYZ         ~~~~");
            Console.WriteLine("~~~~                        ~~~~");
            Console.WriteLine("~~~~ Administrationssystem  ~~~~");
            Console.WriteLine("~~~~                        ~~~~");

            Console.WriteLine();
            Console.WriteLine("Välj siffran 0 för att avsluta Admininstrationssystemet");
            Console.WriteLine("Välj siffran 1 för att starta  Admininstrationssystemet");


            //Vehicle bil01 = new Personbil();
            //Garage<Vehicle> ettFintGarage = new Garage<Vehicle>(bil01);
            Garage<Vehicle> ettFintGarage = new Garage<Vehicle>(10);


        }
    } //- of class Program
} //- of namespace
