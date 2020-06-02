using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerApp
{
    public class Ship
    {
        public List<Place> Places { get; }
        public double MaxWeight { get; }
        public double MinWeight { get; }
        
        public Ship(List<Place> places, double maxWeight)
        {
            Places = places;
            MaxWeight = maxWeight;
            MinWeight = minWeight();
        }

        //Bereken het minimum gewicht van het schip.
        private double minWeight()
        {
            return Convert.ToDouble(MaxWeight / 2);
        }
        
        //To-Do's (Nog Niet KLAAR)


        //Balanceren van het schip om kapseizen te voorkomen.
        public void Balance()
        {
            for (int i = 0; i < 6; i = i + 2)
            {
                if (Places[i + 1].Containers.Count != 0)
                {
                    if ((Places[i].Weight - Places[i + 1].Weight) / Places[i + 1].Weight * 100 > -20)
                        foreach (var container in Places[i].Containers)
                        {
                            if (!container.Valuable)
                            {
                                var placed = Places[i + 1].AddContainer(container);
                                if (placed)
                                {
                                    var deleted = Places[i].DeleteContainer(container);
                                    if (deleted) break;
                                }
                            }
                        }
                }
                else
                {
                    foreach (var container in Places[i].Containers)
                    {
                        if (!container.Valuable)
                        {
                            var placed = Places[i + 1].AddContainer(container);
                            if (placed)
                            {
                                var deleted = Places[i].DeleteContainer(container);
                                if (deleted) break;
                            }
                        }
                    }
                }
            }
        }

        //TO DO BALANS BEREKENEN TUSSEN 2 RIJEN

    }
}
