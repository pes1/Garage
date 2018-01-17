using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1_0
{
    public class Båt : Vehicle 
    {
    

    private   string registreringsNummer = "dot923";
    protected string RegistreringsNummer
    {
        get => registreringsNummer;
        set => registreringsNummer = value;
    }

    


    public Båt(string färg, float Weight, float Length, string regnummer) :
                base(FordonsTyper.Båt, färg, Weight: Weight, Length: Length)
    {
        Console.WriteLine(" {0} båt med regnummer: {1}", this.Color, regnummer);

        this.RegistreringsNummer = regnummer;

        Console.WriteLine("Grattis du har skapat en {0} båt med Regnummer: {1}", this.Color, RegistreringsNummer);
    }


    }//- of class Båt




}
