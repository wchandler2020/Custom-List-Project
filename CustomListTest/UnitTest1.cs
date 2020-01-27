using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            int expectedResult = 1;
            //Act
            willsList.Add(value);
            //Assert
            Assert.AreEqual(expectedResult, willsList.count);
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

            //Assert //[0]
            Assert.AreEqual(expectResult, willsList[0]);
        }

        [TestMethod]
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

            //Assert //[1]
            Assert.AreEqual(expectResult, willsList[1]);
        }

        [TestMethod]
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

            //Assert //[4]
            Assert.AreEqual(expectResult, willsList[4]);
        }

        [TestMethod]
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
            Assert.AreEqual(expectResult, willsList.count);
        }

        [TestMethod]
        public void VerifyCountAfterRemoveFirstValue()
        {
            WilliamsCustomList<int> willsList = new WilliamsCustomList<int>();
            int value = 6;
            int secondValue = 12;
            int expectResult = 12;
            //Act
            willsList.Remove(value);
            //Assert //[1]
            Assert.AreEqual(expectResult, willsList[0]);
        }
    }
}
