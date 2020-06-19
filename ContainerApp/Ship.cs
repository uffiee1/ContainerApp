using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainerApp.Enum;

namespace ContainerApp
{
    public class Ship
    {
        public List<Row> RowList = new List<Row>();

        public int Width { get; set; }
        public int Height { get; set; }

        public Ship(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void CreatStandardStacks(List<Stack> stackList, List<Container> containerList)
        {
            while (containerList.Any(AnyContainer => AnyContainer.IsInStack == false))
            {
                Stack stack = new Stack();
                for (int i = 0; i < containerList.Count; i++)
                {
                    if (!containerList[i].IsInStack)
                    {
                        stack.ByAddingContainer(containerList[i]);
                    }
                }
                stackList.Add(stack);
            }
        }

        public string VerdelingGegevens(List<Stack> stackList)
        {
            List<Stack> links = new List<Stack>();
            List<Stack> rechts = new List<Stack>();
            string result = "";

            decimal TotalStackListWeight = 0;

            foreach (Stack stack in stackList)
            {
                TotalStackListWeight += stack.GetStackWeight();
            } 
            
            for (int i = 0; i < stackList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    links.Add(stackList[i]);
                }
                else
                {
                    rechts.Add(stackList[i]);
                }
            }

            decimal TotalStackListWeightLeft = 0;
            foreach (Stack stack in links)
            {
                TotalStackListWeightLeft += stack.GetStackWeight();
            }

            decimal TotalStackListWeightRight = 0;
            foreach (Stack stack in rechts)
            {
                TotalStackListWeightRight += stack.GetStackWeight();
            }
            return result;
        }

        public void MakeRowsFromStacks(List<Stack> stackList)
        {
            List<Stack> WaardeVolleStacks = stackList.FindAll(stack => stack.StackType == ContainerType.Waardevol);
            Row waardevolleRow = new Row();
            for (int i = 0; i < WaardeVolleStacks.Count; i++)
            {
                if (waardevolleRow.GetNumberStacks() < Width)
                {
                    waardevolleRow.AddStack(WaardeVolleStacks[i]);
                }
                else
                {
                    break;
                }
            }

            if (waardevolleRow.GetNumberStacks() > 0)
            {
                RowList.Add((waardevolleRow));
            }

            while (stackList.Any(AnyStack => !AnyStack.IsInRow))
            {
                if (waardevolleRow.GetNumberStacks() > 0)
                {
                    RowList.Add(waardevolleRow);
                }

                Row row = new Row();
                while (row.GetNumberStacks() != Width)
                {
                    if (stackList.Any(stk => !stk.IsInRow && stk.StackType == ContainerType.Standaard))
                    {
                        row.AddStack(stackList.Find(stk => !stk.IsInRow && stk.StackType == ContainerType.Standaard));
                    }
                    else
                    {
                        break;
                    }
                }

                if (RowList.Count < (Height - 1))
                {
                    RowList.Add(row);
                }
                else
                {
                    break;
                }
            }
        }


        //For Visualize made by Docent
        public void ShipVisualize()
        {
            string stack = "";
            string weight = "";

            for (int rows = 0; rows < RowList.Count; rows++)
            {
                if (rows > 0)
                {
                    stack += '/';
                    weight += '/';
                }

                for (int s = 0; s < RowList[rows].StackList.Count; s++)
                {
                    if (s > 0)
                    {
                        stack += ',';
                        weight += ',';
                    }

                    for (int y = 0; y < RowList[rows].StackList[s].ContainerList.Count; y++)
                    {
                        Container container = RowList[rows].StackList[s].ContainerList[y];
                        stack += Convert.ToString(container.ContainerType);
                        weight += Convert.ToDouble(container.Weight);

                        if (y < (RowList[rows].StackList[s].ContainerList.Count) - 1)
                        {
                            weight += "-";
                        }
                    }
                }
            }

            Process.Start("https://i872272core.venus.fhict.nl/ContainerVisualizer/index.html?length=" + Width +
                          "&width=" + Width + "&stacks=" + stack + "&weights=" + weight + "");
        }
    }
}