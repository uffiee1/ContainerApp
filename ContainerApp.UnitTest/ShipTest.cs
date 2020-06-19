using System;
using System.Collections.Generic;
using ContainerApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerApp.UnitTest
{
    [TestClass]
    public class ShipTest
    {
        [TestMethod]
        public void CheckConstructorShipTrue()
        {
            //Arrange
            Ship ship = new Ship(2, 2); 

            //Act
            bool value1 = ship.Height == 2;
            bool value2 = ship.Width == 2;

            //Assert
            Assert.IsTrue(value1);
            Assert.IsTrue(value2);
        }

        [TestMethod]
        public void CheckConstructorShipFalse()
        {
            //Arrange
            Ship ship = new Ship(4, 2); 

            //Act
            bool value1 = ship.Height == 4;
            bool value2 = ship.Width == 2;

            //Assert
            Assert.IsFalse(value1);
            Assert.IsFalse(value2);
        }

        [TestMethod]
        public void StackCreationShipTrue()
        {
            //Arrange
            Ship ship = new Ship(2, 2);
            List<Container> containerList = new List<Container>();
            Container cont1 = new Container(1, 10000);
            Container cont2 = new Container(2, 113000);
            Container cont3 = new Container(3, 10000);

            containerList.Add(cont1);
            containerList.Add(cont2);
            containerList.Add(cont3);


            List<Stack> stackList = new List<Stack>();
            ship.CreatStandardStacks(stackList, containerList);

            //Act
            bool value = stackList.Count == 2;

            //Assert
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void StackCreationShipFalse()
        {
            //Arrange
            Ship ship = new Ship(2, 2);
            List<Container> containerList = new List<Container>();
            Container cont1 = new Container(1, 10000);
            Container cont2 = new Container(2, 113000);
            Container cont3 = new Container(3, 10000);

            containerList.Add(cont1);
            containerList.Add(cont2);
            containerList.Add(cont3);


            List<Stack> stackList = new List<Stack>();
            ship.CreatStandardStacks(stackList, containerList);

            //Act
            bool value = stackList.Count > 5;

            //Assert
            Assert.IsFalse(value);
        }

        [TestMethod] 
        public void RowCreationShipTrue()
        {
            //Arrange
            Ship ship = new Ship(2, 2);
            List<Container> containerList = new List<Container>();
            Container cont1 = new Container(1, 10000);
            Container cont2 = new Container(2, 113000);
            Container cont3 = new Container(3, 10000);

            containerList.Add(cont1);
            containerList.Add(cont2);
            containerList.Add(cont3);

            List<Stack> stackList = new List<Stack>();
            ship.CreatStandardStacks(stackList, containerList);
            ship.MakeRowsFromStacks(stackList);

            //Act
            bool value = ship.RowList.Count == 1;

            //Assert
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void RowCreationShipFalse()
        {
            //Arrange
            Ship ship = new Ship(2, 2);
            List<Container> containerList = new List<Container>();
            Container cont1 = new Container(1, 10000);
            Container cont2 = new Container(2, 113000);
            Container cont3 = new Container(3, 10000);

            containerList.Add(cont1);
            containerList.Add(cont2);
            containerList.Add(cont3);

            List<Stack> stackList = new List<Stack>();
            ship.CreatStandardStacks(stackList, containerList);
            ship.MakeRowsFromStacks(stackList);

            //Act
            bool value = ship.RowList.Count > 1;

            //Assert
            Assert.IsFalse(value);
        }
    }
}
