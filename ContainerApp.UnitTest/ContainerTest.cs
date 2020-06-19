using System;
using System.ComponentModel;
using ContainerApp.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerApp.UnitTest
{
    [TestClass]
    public class ContainerTest
    {
        [TestMethod]
        public void ContainerWeightTrue()
        {
            //Arrange
            Container container = new Container(0,1000);

            //Act
            bool value = container.Weight == 1000;

            //Assert
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void ContainerWeightFalse()
        {
            //Arrange
            Container container = new Container(0, 500);

            //Act
            bool value = container.Weight == 1000;

            //Assert
            Assert.IsFalse(value);
        }

        [TestMethod]
        public void ContainerTypeTrue()
        {
            //Arrange
            Container container = new Container(0, 500);

            //Act
            bool value = container.ContainerType == ContainerType.Standaard;

            //Assert
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void ContainerTypeFalse()
        {
            //Arrange
            Container container = new Container(0, 500, ContainerType.Waardevol);

            //Act
            bool value = container.ContainerType == ContainerType.Waardevol;

            //Assert
            Assert.IsTrue(value);
        }
    }
}
