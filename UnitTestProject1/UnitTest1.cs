using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzer;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string message = "I am in sad Mood";
            string expectedResult = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser();

            //Act
            string actual = moodAnalyser.AnalyseMood(message);

            //Assert
            Assert.AreEqual(actual, expectedResult);
        }


        //TC1.1-given i am in any mood should return Happy mood
        [TestMethod]
        public void GivenIamInAnyMooShouldReturnHappyMood()
        {
            //Arrange
            string message = "I am in any Mood";
            string expectedResult = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser();

            //Act
            string actual = moodAnalyser.AnalyseMood(message);

            //Assert
            Assert.AreEqual(actual, expectedResult);
        }
    }
}
    

