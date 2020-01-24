using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerifyZeroIndex()
        {
            //Arrange
            WilliamsCustomList<int> willsList = new WilliamsCustomList<int>();
            int value = 10;

            //Act
            willsList.add(value);
            //Assert
            Assert.AreEqual(value, willsList[0]);          
        }

        [TestMethod]

        public void VerifyCountAfterAdd()
        {
            //Arrange
            WilliamsCustomList<int> willsList = new WilliamsCustomList<int>();
            int value = 5;
            int expectResult = 1;
            //Act
            willsList.add(value);
            //Assert
            Assert.AreEqual(value, willsList[]);


        }
    }
}
