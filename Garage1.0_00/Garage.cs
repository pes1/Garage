using System.Collections;
using System.Collections.Generic;

namespace Garage1_0
{
    public class Garage<T> : IEnumerable<T> where T :  Vehicle   //, IBuildABuilding
    {
        public int     ParkingSpots {get { return ParkingSpots = 0;     }
                                     set {        ParkingSpots = value; } }
        public  string Name        { get => name; set =>  name = value; }
        private string name;


        public Garage(Vehicle fordon)
        {
            
        }







        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}