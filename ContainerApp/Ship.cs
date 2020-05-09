using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerApp
{
    class Ship
    {
        public List<Place> Places { get; }
        public double MaxWeight { get; }
        public double MinWeight { get; }
        
        public Ship(List<Place> places, double maxWeight)
        {
            Places = places;
            MaxWeight = maxWeight;
            MinWeight = CalculateMinWeight();
        }

        //Bereken het minimum gewicht van het schip.
        private double CalculateMinWeight()
        {
            return Convert.ToDouble(MaxWeight / 2);
        }
        
        //To-Do's

        //Balanceren van het schip om kapseizen te voorkomen.
        //Berekent de balans tussen rij 1 en rij 2.
    }
}
