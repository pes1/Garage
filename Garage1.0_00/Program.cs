using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1_0
{
    public class Program
    {



        //static void Main(string[] args)
        //{
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            ConfigureGarage.Textutskrift("~~~~                        ~~~~");
            ConfigureGarage.Textutskrift("~~~~     Garage XYZ         ~~~~");
            ConfigureGarage.Textutskrift("~~~~                        ~~~~");
            ConfigureGarage.Textutskrift("~~~~ Administrationssystem  ~~~~");
            ConfigureGarage.Textutskrift("~~~~                        ~~~~");
            ConfigureGarage.Textutskrift("");
            ConfigureGarage.Textutskrift("");
            ConfigureGarage.Textutskrift("Välj siffran 0 för att avsluta Admininstrationssystemet");
            ConfigureGarage.Textutskrift("Välj siffran 1 för att starta  Admininstrationssystemet");

            





            bool run      = ConfigureGarage.StartAdminProgram(); //- Starta eller avsluta 
            int GarageSize = -1;
            if (run)
            {
                ConfigureGarage.Textutskrift("Val av garagestorlek ");
                 GarageSize = ConfigureGarage.garageSize();
            }

            Garage<Vehicle> MittFinaGarage = ConfigureGarage.BuildAGarage(GarageSize);
            while (run)
            {
                
                ConfigureGarage.Textutskrift("Please navigate through the menu by enter the number \n(1, 2..5, 0) of your choice"
                    + "\n1. lista samtliga parkerade fordon"
                    + "\n 2. lägga till och ta bort fordon ur garaget"
                    + "\n3. sätta en kapacitet(antal parkeringsplatser) vid instansieringen av ett nytt garage"
                    + "\n4. hitta ett specifikt fordon via registreringsnumret"
                    + "\n5. söka efter fordon utifrån egenskap, till exempel alla svarta fordon med fyra hjul"
                    + "\n0. Exit the application");

                

                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    ConfigureGarage.NollställTextFält();
                    ConfigureGarage.Textutskrift("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':                   //"lägga till och ta bort fordon ur garaget"
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        return;
                    default:
                        ConfigureGarage.Textutskrift("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            } //- of while

            ConfigureGarage.Textutskrift("\n\n\t ~~~~~~~~~~~~ End of program ~~~~~~~~~~~~");
            ConfigureGarage.Textutskrift("\t ~~~~~~~~~~~~ End of program ~~~~~~~~~~~~");
            ConfigureGarage.Textutskrift("\t ~~~~~~~~~~~~ End of program ~~~~~~~~~~~~");
        }


































        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})]
             * Example of incorrect: (()]), [), {[()}]
             */
        }





















    //static void Main(string[] args)
    //{ 
    //    Console.WriteLine("~~~~                        ~~~~");
    //    Console.WriteLine("~~~~     Garage XYZ         ~~~~");
    //    Console.WriteLine("~~~~                        ~~~~");
    //    Console.WriteLine("~~~~ Administrationssystem  ~~~~");
    //    Console.WriteLine("~~~~                        ~~~~");

    //    Console.WriteLine();
    //    Console.WriteLine("Välj siffran 0 för att avsluta Admininstrationssystemet");
    //    Console.WriteLine("Välj siffran 1 för att starta  Admininstrationssystemet");


    //    //Vehicle bil01 = new Personbil();
    //    //Garage<Vehicle> ettFintGarage = new Garage<Vehicle>(bil01);
    //   // Garage<Vehicle> ettFintGarage = new Garage<Vehicle>(10);


    //} //- of main()



} //- of class Program
} //- of namespace
