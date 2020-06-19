using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainerApp.Enum;

namespace ContainerApp
{
    public class Stack
    {
        public List<Container> ContainerList = new List<Container>();

        public bool IsInRow = false;
        public ContainerType StackType;
        public int ContainerStack = 0;


        private bool HasKindOfContainer(ContainerType type)
        {
            if (ContainerList.Any(cont => cont.ContainerType == type))
            { 
                return true;
            }
            else
            { 
                return false;
            }
        }

        private ContainerType GetStackType()
        {
            if (HasKindOfContainer(ContainerType.Waardevol))
            {
                return ContainerType.Waardevol;
            }
            else
            {
                return ContainerType.Standaard;
            }
        }

        public bool ByAddingContainer(Container Container)
        {
            //check weight
            TotalWeightAboveBottomContainer();
            GetStackWeight();
            if (TotalWeightAboveBottomContainer() + Container.Weight <= Container.MaxWeightOnTop &&
                GetStackWeight() + Container.Weight <= 150000)
            {
                AddContainerToStack(Container);
                Container.StackIndex = ContainerStack;
                ContainerStack++;
                StackType = GetStackType();
                return true;
            }
            else
            {
                return false;
            }
        }

        //Eerste container in de stack
        public decimal TotalWeightAboveBottomContainer()
        {
            List<Container> ContList = ContainerList.Where(ContainerInList => ContainerInList.StackIndex != 0).ToList();
            decimal TotalWeight = 0;
            foreach (Container cont in ContList)
            {
                TotalWeight += cont.Weight;
            }
            return TotalWeight;
        }

        private void AddContainerToStack(Container cont)
        {
            ContainerList.Add(cont);
            cont.IsInStack = true;
        }

        public string StackOfContainerData()
        {
            string result = "";
            foreach (Container cont in ContainerList)
            {
                result += cont.ToString() + Environment.NewLine;
            }

            return result;
        }

        public decimal GetStackWeight()
        {
            decimal weight = 0;
            foreach (Container cont in ContainerList)
            {
                weight += cont.Weight;
            }
            return weight;
        }
    }
}