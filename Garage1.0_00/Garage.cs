using System.Collections;
using System.Collections.Generic;

namespace Garage1_0
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle   //, IBuildABuilding
    {
        public int       NoOfParkingSpots { get => _noOfParkingSpots; set => _noOfParkingSpots = value; }
        public string    Name             { get => name;              set => name              = value; }
        public T[]       ParkingSpots     { get => parkinSpots;       set => parkinSpots       = value; }

        private string name;
        private int    _noOfParkingSpots;
        private T[]    parkinSpots;

        //public Garage(Vehicle fordon)
        //{

        //}

        public Garage(int noOfPSpots =1) : this ("Lilla Torget", noOfPSpots)
        {
           //noOfParkingSpots = noOfPSpots;
           //ParkingSpots     = new  Vehicle[noOfParkingSpots];
        }


        public Garage(string namn, int noOfPSpots = 1)
        {
            NoOfParkingSpots = noOfPSpots;
            ParkingSpots     = new T[NoOfParkingSpots];
            Name             = namn;
        }




        /// <summary>
        /// Parkera ett fordon i garaget efter kontroll av ledig plats finnes.
        /// </summary>
        /// <param name="fordonet"></param>
        /// <returns></returns>
        //- 
        public bool ParkVehicle (Vehicle fordonet)
        {
            return true;
        }

        /// <summary>
        /// Kontrollera om ledig plats finnes.
        /// </summary>
        /// <returns></returns>
        public bool CheckForFreeSpace()
        {
            foreach(T plats in ParkingSpots)
            {   if (  plats== null) { return true; }}
            return false;
        }
         

    public IEnumerator<T> GetEnumerator()
        {
            for (int index = 0; index < ParkingSpots.Length; index++)
            {
                 yield return ParkingSpots[index];
            }
        }


        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

      
    }
}