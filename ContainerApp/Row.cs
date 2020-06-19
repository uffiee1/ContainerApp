using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerApp
{
    public class Row
    {
        public List<Stack> StackList = new List<Stack>();
        
        public int GetNumberStacks()
        {
            return StackList.Count();
        } 

        public void AddStack(Stack stack)
        {
            stack.IsInRow = true;
            StackList.Add(stack);
        }

        public decimal GetRowWeight()
        {
            decimal weight = 0;
            foreach (Stack item in StackList)
            {
                weight += item.GetStackWeight();
            }
            return weight;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Stack stack in StackList)
            {
                result += stack.StackOfContainerData() + Environment.NewLine;
            }
            return result;
        }
    }
}
