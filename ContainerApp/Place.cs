using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerApp
{
    public class Place
    {
        public List<Container> Containers { get; } = new List<Container>();
        public double Weight { get; private set; }
        private int Position { get; }

        public Place(int position)
        {
            Position = position;
        }

        //Voeg de container toe aan de lijst terwijl het gewicht controleert.
        public bool AddContainer(Container model)
        {
            if (!model.Valuable || Containers.Find(x => (x.Valuable)) == null)
            {
                if (CheckWeight(model.Weight))
                {
                    Containers.Add(model);
                    return true;
                }
                return false;
            }
            return false;
        }

        private bool CheckWeight(double weight)
        {
            if (Weight + weight <= 150000)
            {
                Weight = Weight + weight;
                return true;
            }
            return false;
        }

        //Container verwijderen en gewicht aftrekken.
        public bool DeleteContainer(Container model)
        {
            var deleted = Containers.Remove(model);
            if (deleted)
            {
                Weight = Weight - model.Weight;
                return true;
            }
            return false;
        }
    }
}
