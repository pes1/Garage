using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1_0
{
    class ConfigureGarage
    {
        public static bool StartAdminProgram()
        {

            //- tanken är att få getInput att leverera ett antal insträngar och val från StartAdminProgram().
            if (getLongInput()) { return true; }
            else { return false; }


        }

        //- How   big   a garage is wanted ?
        public static int garageSize()
        {
            return getValueInput();
        }

        public static Garage<Vehicle> BuildAGarage(int noOfParkinSpots)
        {

            Garage<Vehicle> ettFintGarage = new Garage<Vehicle>(noOfParkinSpots);
            return ettFintGarage;

        }









        static int getValueInput()
        {
            int val = 9999;
            bool run = true;
            int minimiStorlek = 1;
            int maximiStorlek = 100;

            while (run)
            {
                string texten = Inmatning("\n\nAnge Hur stort garaget skall vara."
                                        + "\nAnge i form av antal parkeringsplatser");

                if (isItAnumber(texten, minimiStorlek, maximiStorlek)) { val = Convert.ToInt32(texten); }
                else { val = -1; }

                if (!(val < 0))
                {
                    return val;//$$$$$$$$$$$$$$$$$$$$$
                }
                else { Textutskrift("Ogiltigt val"); run = true; break; }

            } //- of while
            return -1;  //- 
        }













        static bool getLongInput()
        {
            int val = 9999;
            bool run = true;

            while (run)
            {
                string texten = Inmatning("\n\nAnge val (0  eller 1) : ");

                if (isItAnumber(texten, 0, 1)) { val = Convert.ToInt32(texten); }
                else { val = -1; }

                switch (val)
                {
                    case 0: Textutskrift("Avslutar program " + val); run = false; return false;
                    case 1: Textutskrift("Startar GarageProgram"); run = true; return true;
                    default: Textutskrift("Ogiltigt val"); run = true; break;
                }

            } //- of while
            return false;  //- 
        }




        private static string Inmatning(string UtskriftsText)
        {

            // Console.WriteLine("Ange val: ");
            Textutskrift(UtskriftsText);
            //var input1 = Console.ReadLine();
            string input1 = Console.ReadLine();
            return input1;
        }




        //int Inmatning(string UtskriftsText, lägstaVärde, högstavärde)
        private static bool isItAnumber(string input1, int lägstaVärde, int högstavärde)
        {
            int number = 0;
            try
            {
                bool canConvert = int.TryParse(input1, out number);
                if (canConvert == true)
                {
                    if ((number >= lägstaVärde) && (number <= högstavärde))
                    {
                        return true;
                    }
                }
                else
                {
                    //Console.WriteLine("för avslutande av kassa, skriv avslut !");
                    return false;
                }
            }
            catch
            {
                Textutskrift("Fel format");
                return false;
            }
            return false;
        }//- of isItAnumber





        // --------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------
        internal static void Textutskrift(string utskrift)
        {
            Console.WriteLine(utskrift);
        }


        // --------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------
        internal static void NollställTextFält()
        {
            Console.Clear();
        }


        // --------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------

        bool isItValidText(string input1, string validText)
        {
            if (input1 == validText) { return true; }
            else { return false; }
        }//- of isItValidText


        // --------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------






























    } //- of class
}
