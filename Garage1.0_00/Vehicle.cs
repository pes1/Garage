namespace Garage1_0
{
    public abstract class Vehicle
    {
        public enum FordonsTyper
        {
            None,
            Personbil,
            Lastbil,
            Buss,
            Släpvagn,
            Moped,
            Motorcykel,
            Traktor,
            Motorredskap,
            Snöskoter,
            Terränghjuling,
            Terrängskoter,
            Terrängsläp,
            Terrängvagn,
            Flygplan,
            Båt,
            Last
        }

        public string        Color       { get; private set; }
        public float         Weight      { get; private set; }
        public float         Length      { get; private set; }
        public FordonsTyper  VehicleType { get; private set; }

        public Vehicle() //- test av konstruktorer
        {
            VehicleType = FordonsTyper.Personbil;
            Color = "NoColor";
            Weight = 0f;              // default
            Length = 0f;              // default
        }
        public Vehicle(FordonsTyper fordonsTyp, string färg)
        {
            VehicleType = fordonsTyp;
            Color = färg;
            System.Console.WriteLine("Vehicle av typen: {0}", fordonsTyp);
        }

        

        public Vehicle(FordonsTyper fordonsTyp, string färg, float Weight, float Length)
        {
            VehicleType = fordonsTyp;
            Color = färg;
            this.Weight = Weight;
            this.Length = Length;
            System.Console.WriteLine("Vehicle av typen: {0} vilket väger: {1} kg med längden: {2} m", 
                                    fordonsTyp, this.Weight, this.Length);
        }




    }//- of class




 
    








































    //- motorfordon enl. trafikverket
    //    P personbil
    //Ph personbil med husvagn
    //LBm små lastbilar, minibussar mm
    //Los oljebil och sopbil
    //LBn 2- till 4-axliga stora lastbilar och stadsbussar
    //Bf förlängd normalbuss
    //Bb boggiebuss
    //Bl ledbuss
    //Lps lastbil med påhängsvagn eller släpvagn
    //Ls skogsbil
    //Ts traktor med släp
    //S skördetröska
    //Lm modulfordon
    //Lsp specialfordon



    //Personbil       
    //Lastbil        
    //Buss	        
    //Släpvagn  
    //Moped	        
    //Motorcykel    
    //Traktor         
    //Motorredskap
    //Snöskoter	    
    //Terränghjuling
    //Terrängskoter	
    //Terrängsläp	                         
    //Terrängvagn












}