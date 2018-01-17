using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1_0
{
    public class Flygplan : Vehicle
    {
        private string registreringsNummer = "SE123";
        private int antalHjul = 8;
        protected string RegistreringsNummer
        {
            get => registreringsNummer;
            set => registreringsNummer = value;
        }
        protected int AntalHjul
        {
            get => antalHjul;
            set => antalHjul = value;
        }

        public Flygplan(string färg, float Weight, float Length, string regnummer) :
                    base(FordonsTyper.Flygplan, färg, Weight: Weight, Length: Length)
        {
            Console.WriteLine(" {0} {1} med Regnummer: {2}", this.Color, this.GetType().Name, regnummer);

            this.RegistreringsNummer = regnummer;
            //Console.WriteLine(" ........OBJECT-typ {0} ...........", this.GetType().Name);
            Console.WriteLine("Grattis du har skapat en {0} {1} med Regnummer: {2}", this.Color, this.GetType().Name, RegistreringsNummer);
        }
    }
}
