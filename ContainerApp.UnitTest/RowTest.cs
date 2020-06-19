using System;
using ContainerApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerApp.UnitTest
{
    [TestClass]
    public class RowTest
    {
        [TestMethod]
        public void CheckStackAmountInRowTrue()
        {
             //Arrange
            Container Container = new Container(0, 3000);
            Stack stack = new Stack();
            Row row = new Row();
            stack.ByAddingContainer(Container);
            row.AddStack(stack);

            //Act
            bool value = row.GetNumberStacks() == 1;

            //Assert
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void CheckStackAmountInRowFalse()
        {
            //Arrange
            Container container = new Container(0, 1000);
            Stack stack = new Stack();
            Row row = new Row();
            stack.ByAddingContainer(container);
            row.AddStack(stack);
            row.AddStack(stack);
            //Act
            bool value = row.GetNumberStacks() == 1;

            //Assert
            Assert.IsFalse(value);
        }

        [TestMethod]
        public void CheckRowWeightInStacksTrue()
        {
            //Arrange
            Container container = new Container(0, 1000);
            Stack stack = new Stack();
            Row row = new Row();
            stack.ByAddingContainer(container);
            row.AddStack(stack);

            //Act
            bool value = row.GetRowWeight() == 1000;

            //Assert
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void CheckRowWeightInStacksFalse()
        {
            //Arrange
            Container container = new Container(0, 1000);
            Stack stack = new Stack();
            Row row = new Row();
            stack.ByAddingContainer(container);
            row.AddStack(stack);

            //Act
            bool value = row.GetRowWeight() == 2000;

            //Assert
            Assert.IsFalse(value);
        }
    }
}
