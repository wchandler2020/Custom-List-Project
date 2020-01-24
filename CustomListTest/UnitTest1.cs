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
            willsList.Add(value);
            //Assert
            Assert.AreEqual(1, willsList.Count);          
        }

        [TestMethod]

        public void VerifyCountAfterAddValue()
        {
            //Arrange
            WilliamsCustomList<int> willsList = new WilliamsCustomList<int>();
            int value = 6;
            int expectResult = 6;
            //Act
            willsList.Add(value);
            
            //Assert
            Assert.AreEqual(expectResult, willsList[0]);
        }

        public void VerifyCountAfterAddSecondValue()
        {
            //Arrange
            WilliamsCustomList<int> willsList = new WilliamsCustomList<int>();
            int value = 6;
            int secondValue = 12;
            int expectResult = 12;
            //Act
            willsList.Add(value);
            willsList.Add(secondValue);

            //Assert
            Assert.AreEqual(expectResult, willsList[1]);
        }

        public void VerifyCountAfterAddMultipleValue()
        {
            //Arrange
            WilliamsCustomList<int> willsList = new WilliamsCustomList<int>();
            int value = 6;
            int secondValue = 12;
            int thirdValue = 18;
            int fourthValue = 24;
            int fifthValue = 30;

            int expectResult = 30;
            //Act
            willsList.Add(value);
            willsList.Add(secondValue);
            willsList.Add(thirdValue);
            willsList.Add(fourthValue);
            willsList.Add(fifthValue);

            //Assert
            Assert.AreEqual(expectResult, willsList[4]);
        }

        public void VerifyTotalIndexCountValue()
        {
            //Arrange
            WilliamsCustomList<int> willsList = new WilliamsCustomList<int>();
            int value = 6;
            int secondValue = 12;
            int thirdValue = 18;
            int fourthValue = 24;
            int fifthValue = 30;

            int expectResult = 5;
            //Act
            willsList.Add(value);
            willsList.Add(secondValue);
            willsList.Add(thirdValue);
            willsList.Add(fourthValue);
            willsList.Add(fifthValue);

            //Assert
            Assert.AreEqual(expectResult, willsList.Count);
        }

    }
}
