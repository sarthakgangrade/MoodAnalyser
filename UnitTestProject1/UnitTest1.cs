using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzer;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private string message;

        /*//TC1.1-given I am in sad mood should return sad
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
//TC3.1-given Null mood should throw custom exception
[TestMethod]
public void GivenNullMoodShouldShowCustomException()
{
//Arrange
string message = null;
string expectedResult = "Mood can't be Null";
MoodAnalyser moodAnalyser = new MoodAnalyser(message);

try
{
//Act
string actual = moodAnalyser.AnalyseMood(message);
}
//catching exception checking result matches
catch (NewCustomException ex)
{
//Assert
Assert.AreEqual(expectedResult, ex.Message);
}

}

/*
//TC3.2 - given empty mood should throw exception indicating empty mood
[TestMethod]
public void GivenEmptyMoodShouldThrowCustomExceptionIndicatingEmptyMood()
{
//Arrange
//string message = " ";
string expectedResult = "Mood can't be empty";
MoodAnalyser moodAnalyser = new MoodAnalyser(string.Empty);
try
{
//Act
string actual = moodAnalyser.AnalyseMood();
}
catch(NewCustomException ex)
{
//Assert
Assert.AreEqual(expectedResult, ex.Message);
}

} */
        //TC4.1-Given mood analyser class name should return mood analyser object
        [TestMethod]
        public void GivenMoodAnalyserClassNameShouldReturnMoodAnalyserObject()
        {
            //Arrange
            MoodAnalyser expected = new MoodAnalyser(message);
            //
            object obj = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyzer.MoodAnalyser", "MoodAnalyser");
            //
            expected.Equals(obj);
        }

        //TC4.2-Given mood analyser class name should return mood analyser object
        [TestMethod]
        public void GivenImproperClassNameShouldThrowEcxception()
        {
            //Arrange
            MoodAnalyser expected = new MoodAnalyser();
            object obj = null;
            try
            {
                obj = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyzer.Mood", "MoodAnalyser");
            }
            catch (NewCustomException)
            {
                throw new NewCustomException(NewCustomException.ExceptionType.CLASS_NOT_FOUND, "No such class is present");
                //throw new Exception(ex.Message);

            }
            expected.Equals(obj);
        }
    }
}
