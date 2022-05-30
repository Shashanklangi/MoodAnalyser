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
            moodAnalyzer = new MoodAnalyzer();
        }

        [Test]
        public void Given_Message_In_Sad_Mood_Return_Sad_Message()
        {
            //Arrange
            string message = "I am in SAD Mood";
            moodAnalyzer = new MoodAnalyzer();

            //Act
            string expected = "SAD";
            string actual = moodAnalyzer.AnalyseMood(message);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Given_Message_In_Happy_Mood_Return_Happy_Message()
        {
            //Arrange
            string message = "I am in Any Mood";
            moodAnalyzer = new MoodAnalyzer();

            //Act
            string expected = "HAPPY";
            string actual = moodAnalyzer.AnalyseMood(message);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}