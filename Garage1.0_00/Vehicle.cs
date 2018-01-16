namespace Garage1_0
{
    public class Vehicle
    {
        enum FordonsTyper
        {
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
            Airplane,
            Båt
        }

        public string Color { get; private set; }
        public float Weight { get; private set; }
        public float Length { get; private set; }
        private FordonsTyper VehicleType { get; }

        public Vehicle()
        {
            VehicleType = FordonsTyper.Personbil;
            Color = "NoColor";
            Weight = 0f;              // default
            Length = 0f;              // default

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