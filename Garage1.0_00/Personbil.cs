using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1_0

{
    public class Personbil : Vehicle
    {
        private   string registreringsNummer = "ABC123";
        protected string RegistreringsNummer
                    { get => registreringsNummer;
                      set => registreringsNummer = value; }

        public Personbil():base() { }

        public Personbil(string bilfärg) : base(FordonsTyper.Personbil, bilfärg)
        {
            
            //if (fordonet == FordonsTyper.Personbil)
            //{
            Console.WriteLine("Grattis du har skapat en bil " + this.Color);
            //}
        }


        public Personbil(string bilfärg, float Weight, float Length, string regnummer) : 
                    base(FordonsTyper.Personbil, bilfärg, Weight:Weight, Length:Length)
        {
            Console.WriteLine(" {0} Personbil med Regnummer: {1}", this.Color, regnummer);

            this.RegistreringsNummer = regnummer;
            
            Console.WriteLine("Grattis du har skapat en {0} bil med Regnummer: {1}", this.Color, RegistreringsNummer);
        }

    }
}
