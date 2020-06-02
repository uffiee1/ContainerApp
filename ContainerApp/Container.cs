using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerApp
{
    public class Container
    {
        public bool Valuable { get; }
        public bool Cooled { get; }
        public double Weight { get; }

        public Container(bool valuable, bool cooled, double weight)
        {
            Valuable = valuable;
            Cooled = cooled;
            Weight = weight;
        }

    }
}
