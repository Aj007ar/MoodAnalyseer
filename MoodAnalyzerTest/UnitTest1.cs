using MoodAnalyser;
namespace MoodAnalyzerTest
{
    public class Tests
    {

        [Test]
        public void givenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
             MoodAnalyserProgram Sadmood= new MoodAnalyserProgram("Sad");
            string expected = "sad";
            string actual = Sadmood.MoodMessage();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void givenMessage_WhenHappy_ShouldReturnSad()
        {
            MoodAnalyserProgram Anymood = new MoodAnalyserProgram("Happy");
            string expected = "sad";
            string actual = Anymood.MoodMessage();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void givenMessage_WhenHappy_ShouldReturnHappy()
        {
            MoodAnalyserProgram Happymood = new MoodAnalyserProgram("Happy");
            string expected = "Happy";
            string actual = Happymood.MoodMessage();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void givenMessage_WhenSad_ShouldReturnHappy()
        {
            MoodAnalyserProgram anymood = new MoodAnalyserProgram("sad");
            string expected = "Happy";
            string actual = anymood.MoodMessage();
            Assert.AreEqual(expected, actual);
        }
    }
}