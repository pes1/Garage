using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1_0
{
    // class ConfigureGarage<T> : IEnumerable<T> where T : Vehicle
     public class ConfigureGarage
    {
        private Object ettGarage = null;
        public  Object EttGarage { get => ettGarage; set => ettGarage = value; }



        public static bool StartAdminProgram()
        {
            //- tanken är att få getInput att leverera ett antal insträngar och val från StartAdminProgram().
            if (getLongInput()) { return true; }
            else { return false; }
        }

        //- How   big   a garage is wanted ?
        public static int garageSize(string garageSizeQuestion)
        {
            return getValueInput(minimiStorlek: 1, maximiStorlek:100, outputText:garageSizeQuestion);
        }

        // --------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------

        public static  Object BuildAGarage(int noOfParkinSpots)
        {
            ConfigureGarage DetNyaGaraget = new ConfigureGarage();
            DetNyaGaraget.EttGarage =   new Garage<Vehicle>(noOfParkinSpots);
            return DetNyaGaraget;
        }








            public static int getValueInput(int minimiStorlek, int maximiStorlek, string outputText)
            {
            int val = 9999;
            bool run = true;
            //int minimiStorlek = 1;
            //int maximiStorlek = 100;

            while (run)
            {
                string texten = Inmatning(outputText);

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


        Vehicle personbil(string bilfärg, float Weight, float Length, string regnummer)
        {
            return personbil(bilfärg: bilfärg, Weight: Weight, Length: Length, regnummer: regnummer);
        }


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
        public   static void NollställSkärm() { NollställTextFält(); }
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

        //public IEnumerator<Vehicle> GetEnumerator()
        //{
        //    return ((IEnumerable<Vehicle>)EttGarage).GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return ((IEnumerable<Vehicle>)EttGarage).GetEnumerator();
        //}


        // --------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------






























    } //- of class
}
