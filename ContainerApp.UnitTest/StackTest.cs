using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerApp.UnitTest
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void AddToStackTrue()
        {
            //Arrange
            Container Container = new Container(0, 1000);
            Stack stack = new Stack(); 

            //Act
            bool value = stack.ByAddingContainer(Container);

            //Assert
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void AddToStackFalse()
        {
            //Arrange
            Container Container = new Container(0, 150001);
            Stack stack = new Stack();

            //Act
            bool value = stack.ByAddingContainer(Container);

            //Assert
            Assert.IsFalse(value);
        }
        
        [TestMethod]
        public void GetWeightAboveFirstContainerTrue()
        {
            //Arrange
            Container firstContainer = new Container(0, 1000);
            Container containerAboveFirstContainer = new Container(0, 5000);

            Stack stack = new Stack();
            stack.ByAddingContainer(firstContainer);
            stack.ByAddingContainer(containerAboveFirstContainer);

            //Act
            bool value = stack.TotalWeightAboveBottomContainer() == 5000;

            //Assert
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void GetWeightAboveFirstContainerFalse()
        {
            //Arrange
            Container firstContainer = new Container(0, 1000);
            Container containerAboveFirstContainer = new Container(0, 15000);

            Stack stack = new Stack();
            stack.ByAddingContainer(firstContainer);
            stack.ByAddingContainer(containerAboveFirstContainer);

            //Act
            bool value = stack.TotalWeightAboveBottomContainer() == 5000;

            //Assert
            Assert.IsFalse(value);
        }

        [TestMethod]
        public void GetStackWeightTrue()
        {
            //Arrange
            Container firstContainer = new Container(0, 1000);
            Container containerAboveFirstContainer = new Container(0, 15000);

            Stack stack = new Stack();
            stack.ByAddingContainer(firstContainer);
            stack.ByAddingContainer(containerAboveFirstContainer);

            //Act
            bool value = stack.GetStackWeight() == 16000;

            //Assert
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void GetStackWeightFalse()
        {
            //Arrange
            Container firstContainer = new Container(0, 100);
            Container containerAboveFirstContainer = new Container(0, 15000);

            Stack stack = new Stack();
            stack.ByAddingContainer(firstContainer);
            stack.ByAddingContainer(containerAboveFirstContainer);

            //Act
            bool value = stack.GetStackWeight() == 16000;

            //Assert
            Assert.IsFalse(value);
        }
    }
}
