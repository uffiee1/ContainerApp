using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainerApp.Enum;

namespace ContainerApp
{
    public class Container
    {
        //Container Props
        public int ContainerId { get; set; }
        public ContainerType ContainerType { get; set; }
        public decimal Weight { get; set; }
        public decimal MaxWeightOnTop { get; set; }
        public double MaxWeight { get; set; }
        public double MinWeight { get; set; }
        public bool IsInStack = false;
        public int StackIndex { get; set; }

        public Container(int id, decimal weight, ContainerType type = ContainerType.Standaard)
        {
            ContainerId = id;
            ContainerType = type;
            MinWeight = 4000; //4000 Container = Empty
            MaxWeight = 30000; //30000 Cotainer = Full
            Weight = weight;
            MaxWeightOnTop = 120000; //Stack: 30000 + 120000 = Full
        }

        public override string ToString()
        {
            return $"ContainerID: {ContainerId},  Type: {ContainerType},  Weight: {Weight.ToString()}";
        } 
    }
}
