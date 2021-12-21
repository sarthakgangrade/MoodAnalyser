using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzer;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //TC1.1-given I am in sad mood should return sad
        [TestMethod]
        public void GivenSadMessageShouldReturnSadMood()
        {
            //Arrange
            string message = "I am in sad Mood";
            string expectedResult = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string actual = moodAnalyser.AnalyseMood(message);
            //Assert
            Assert.AreEqual(actual, expectedResult);
        }

        //TC1.2-given i am in happy mood should return sad mood
        [TestMethod]
        public void GivenIamInHappyMooShouldReturnSadMood()
        {
            //Arrange
            string message = "I am in happy Mood";
            string expectedResult = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            //Act
            string actual = moodAnalyser.AnalyseMood(message);

            //Assert
            Assert.AreEqual(actual, expectedResult);
        }


        //TC2.1-given Null mood should return Happy 
        [TestMethod]
        public void GivenNullMoodShouldReturnHappyMood()
        {
            //Arrange
            string message = null;
            string expectedResult = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            //Act
            string actual = moodAnalyser.AnalyseMood(message);

            //Assert
            Assert.AreEqual(actual, expectedResult);
        }

    }
}
