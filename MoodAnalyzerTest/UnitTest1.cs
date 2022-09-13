using MoodAnalyser;
namespace MoodAnalyzerTest
{
    public class Tests
    {
        //Positive Test Case for Sad mood
        [Test]
        public void givenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
             MoodAnalyserProgram Sadmood= new MoodAnalyserProgram("Sad");
            string expected = "sad";
            string actual = Sadmood.MoodMessage();
            Assert.AreEqual(expected, actual);
        }
        //Negative test case for Sad mood
        [Test]
        public void givenMessage_WhenHappy_ShouldReturnSad()
        {
            MoodAnalyserProgram Anymood = new MoodAnalyserProgram("Happy");
            string expected = "sad";
            string actual = Anymood.MoodMessage();
            Assert.AreEqual(expected, actual);
        }
        //positive test case for Happy mood
        [Test]
        public void givenMessage_WhenHappy_ShouldReturnHappy()
        {
            MoodAnalyserProgram Happymood = new MoodAnalyserProgram("Happy");
            string expected = "Happy";
            string actual = Happymood.MoodMessage();
            Assert.AreEqual(expected, actual);
        }
        //Negative test case for Happy mood
        [Test]
        public void givenMessage_WhenSad_ShouldReturnHappy()
        {
            MoodAnalyserProgram anymood = new MoodAnalyserProgram("sad");
            string expected = "Happy";
            string actual = anymood.MoodMessage();
            Assert.AreEqual(expected, actual);
        }
        //Test for Null message
        [Test]
        public void givenMessage_with_Null()
        {
            MoodAnalyserProgram nullObj = new MoodAnalyserProgram(null);
            try
            {
                
                nullObj.MoodMessage();
            }
            catch(MoodAnalyserCustomException e)
            {
                string expected = "Mood Can not be Null";
                Assert.AreEqual(expected, e.Message);
            }
        }
        //test for empty message
        [Test]
        public void givenMessage_with_Empty()
        {
            string empty = "";
            MoodAnalyserProgram nullObj = new MoodAnalyserProgram(empty);
            try
            {

                nullObj.MoodMessage();
            }
            catch (MoodAnalyserCustomException e)
            {
                string expected = "Mood Can not be empty";
                Assert.AreEqual(expected, e.Message);
            }
        }
        //Positive Test for class name
        [Test]
        public void Given_Reflection_with_ClassName()
        {
            object expected = new MoodAnalyserProgram();
            object actual = MoodAnalyserFactory.CreateObjectForMoodAnalyse("MoodAnalyser.MoodAnalyserProgram", "MoodAnalyserProgram");
            expected.Equals(actual);
        }
        //Negative Test for Class Not found
        [Test]
        public void Negative_Test_for_Reflection_Class()
        {
            string expected = "No class Found";
            try
            {
                object actual = MoodAnalyserFactory.CreateObjectForMoodAnalyse("MoodAnalyser.MoodAnalyserProgra", "MoodAnalyserProgra");
            }
            catch(MoodAnalyserCustomException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        //Test For Construcror found
        [Test]
        public void Given_Reflection_with_ConstructorName()
        {
            object expected = new MoodAnalyserProgram();
            object actual = MoodAnalyserFactory.CreateObjectForMoodAnalyse("MoodAnalyser.MoodAnalyserProgram", "MoodAnalyserProgram");
            expected.Equals(actual);
        }
        //Negative Test for Constructor Not found
        [Test]
        public void Negative_Test_for_Reflection_Constructor()
        {
            string expected = "No constructor found";
            try
            {
                object actual = MoodAnalyserFactory.CreateObjectForMoodAnalyse("MoodAnalyser.MoodAnalyserProgram", "MoodAnalyserProgra");
            }
            catch (MoodAnalyserCustomException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
    }
}