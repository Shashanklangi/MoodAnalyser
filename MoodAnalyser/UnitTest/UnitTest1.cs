using NUnit.Framework;
using MoodAnalyzerTest;


namespace MoodAnalyzerTest
{
    public class Tests
    {
        MoodAnalyzer moodAnalyzer;
        [SetUp]
        public void Setup()
        {
            moodAnalyzer = new MoodAnalyzer(" I am in SAD mood");
        }
        //<summary>
        //uc1Refactor-1.1 :Given message "I am in SAD mood" returns SAD
        //</summary>
        [Test]
        public void Given_Message_In_Sad_Mood_Return_Sad_Message()
        {
            //Arrange
            string message = "I am in SAD Mood";
            moodAnalyzer = new MoodAnalyzer(message);

            //Act
            string expected = "SAD";
            string actual = moodAnalyzer.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        //<summary>
        //uc1Refactor-1.2 :Given message "I am in any mood" returns HAPPY
        //</summary>
        [Test]
        public void Given_Message_In_Happy_Mood_Return_Happy_Message()
        {
            //Arrange
            string message = "I am in Any Mood";
            moodAnalyzer = new MoodAnalyzer(message);

            //Act
            string expected = "HAPPY";
            string actual = moodAnalyzer.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}